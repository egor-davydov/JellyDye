using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Code.StaticData.Token;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using UnityEngine.ResourceManagement.AsyncOperations;
using Object = UnityEngine.Object;

namespace Code.Services.AssetManagement
{
  public class AddressablesAssetProvider : IAssetProvider
  {
    private readonly Dictionary<string, AsyncOperationHandle> _completedCache = new();

    private readonly StaticDataService _staticDataService;

    public AddressablesAssetProvider(StaticDataService staticDataService) => 
      _staticDataService = staticDataService;

    public void Initialize()
    {
      Addressables.InitializeAsync();
      CCDTokensStaticData ccdTokensStaticData = _staticDataService.ForCCDTokens();
      if(default != ccdTokensStaticData.Configs.FirstOrDefault(config => config.ProfileName == ccdTokensStaticData.ActiveProfileName))
        Addressables.WebRequestOverride += AddressablesWebRequestOverride;
    }

    public async UniTask<T> Load<T>(AssetReference assetReference) where T : Object
    {
      if (_completedCache.TryGetValue(assetReference.AssetGUID, out AsyncOperationHandle completedHandle))
        return await completedHandle.Convert<T>().Task;
      AsyncOperationHandle<T> handle = Addressables.LoadAssetAsync<T>(assetReference.AssetGUID);
      _completedCache[assetReference.AssetGUID] = handle;

      return await handle.Task;
    }

    public async UniTask<T> Load<T>(string address) where T : Object
    {
      if (_completedCache.TryGetValue(address, out AsyncOperationHandle completedHandle))
        return await completedHandle.Convert<T>().Task;

      AsyncOperationHandle<T> handle = Addressables.LoadAssetAsync<T>(address);
      _completedCache[address] = handle;

      return await handle.Task;
    }

    public UniTask<GameObject> Instantiate(string address, Vector3 at) =>
      Addressables.InstantiateAsync(address, at, Quaternion.identity).ToUniTask();

    public UniTask<GameObject> Instantiate(string address, Transform under = null) =>
      Addressables.InstantiateAsync(address, under).ToUniTask();

    public void Cleanup()
    {
      foreach (AsyncOperationHandle handle in _completedCache.Values)
        Addressables.Release(handle);

      _completedCache.Clear();
    }

    private void AddressablesWebRequestOverride(UnityWebRequest overrideWebRequest)
    {
      CCDTokensStaticData ccdTokensStaticData = _staticDataService.ForCCDTokens();
      string token = ccdTokensStaticData.Configs.First(config => config.ProfileName == ccdTokensStaticData.ActiveProfileName).Token;
      string authorization = "Basic " + Authenticate("", token);
      overrideWebRequest.SetRequestHeader("Authorization", authorization);
    }

    private string Authenticate(string username, string password)
    {
      string authenticate = username + ":" + password;
      return Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(authenticate));
    }
  }
}
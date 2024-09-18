using System;
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
    private Dictionary<object, AsyncOperationHandle> _completedCache;

    private readonly StaticDataService _staticDataService;
    private Func<CCDTokenConfig, bool> _ccdTokensPredicate;

    public AddressablesAssetProvider(StaticDataService staticDataService) =>
      _staticDataService = staticDataService;

    public void Initialize()
    {
      int levelPrefabsCount = _staticDataService.ForLevels().LevelConfigs.Length;
      int jellyMeshesCount = _staticDataService.ForLevels().LevelConfigs.Sum(x => x.JellyMeshConfigs.Count);
      int skinsCount = _staticDataService.ForSkins().SkinConfigs.Length;
      int assetsCount = levelPrefabsCount + jellyMeshesCount + skinsCount + 10;
      _completedCache = new(assetsCount);
      Addressables.InitializeAsync();
      CCDTokensStaticData ccdTokensStaticData = _staticDataService.ForCCDTokens();
      _ccdTokensPredicate = config => config.ProfileName == ccdTokensStaticData.ActiveProfileName;
      if (default != ccdTokensStaticData.Configs.FirstOrDefault(config => config.ProfileName == ccdTokensStaticData.ActiveProfileName))
        Addressables.WebRequestOverride += AddressablesWebRequestOverride;
    }

    public bool TryGetAsyncOperationHandle(AssetReference assetReference, out AsyncOperationHandle handle)
    {
      if (_completedCache.TryGetValue(assetReference.RuntimeKey, out AsyncOperationHandle completedHandle)) ;
      {
        handle = completedHandle;
        return true;
      }
    }

    public async UniTask<T> Load<T>(AssetReference assetReference) where T : Object
    {
      return await LoadByKey<T>(assetReference.RuntimeKey);
    }

    public async UniTask<T> Load<T>(string address) where T : Object
    {
      return await LoadByKey<T>(address);
    }

    private async UniTask<T> LoadByKey<T>(object key) where T : Object
    {
      if (_completedCache.TryGetValue(key, out AsyncOperationHandle completedHandle))
        return await completedHandle.Convert<T>();

      AsyncOperationHandle<T> handle = Addressables.LoadAssetAsync<T>(key);
      _completedCache[key] = handle;

      return await handle;
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

    public AsyncOperationHandle GetHandle(AssetReference assetReference) =>
      _completedCache[assetReference.RuntimeKey];

    public AsyncOperationHandle GetHandle(string address) =>
      _completedCache[address];

    private void AddressablesWebRequestOverride(UnityWebRequest overrideWebRequest)
    {
      CCDTokensStaticData ccdTokensStaticData = _staticDataService.ForCCDTokens();
      string token = ccdTokensStaticData.Configs.First(_ccdTokensPredicate).Token;
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
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Code.Services.AssetManagement
{
  public class AddressablesAssetProvider : IAssetProvider
  {
    private readonly Dictionary<string, AsyncOperationHandle> _completedCache = new();

    public void Initialize() => 
      Addressables.InitializeAsync();

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
  }
}
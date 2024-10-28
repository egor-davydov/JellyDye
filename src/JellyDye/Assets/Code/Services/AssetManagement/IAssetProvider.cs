using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Code.Services.AssetManagement
{
  public interface IAssetProvider
  {
    void Initialize();
    UniTask<T> Load<T>(AssetReference reference) where T : Object;
    UniTask<T> Load<T>(string key) where T : Object;
    UniTask<GameObject> Instantiate(string path, Vector3 at);
    UniTask<GameObject> Instantiate(string address, Transform under = null);
    void Cleanup();
    AsyncOperationHandle WarmUpAsset<T>(AssetReference assetReference) where T : Object;
    AsyncOperationHandle WarmUpAsset<T>(string key) where T : Object;
  }
}
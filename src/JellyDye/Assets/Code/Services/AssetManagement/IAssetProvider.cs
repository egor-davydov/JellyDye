using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Code.Services.AssetManagement
{
    public interface IAssetProvider
    {
        void Initialize();
        UniTask<T> Load<T>(AssetReference reference) where T : Object;
        UniTask<T> Load<T>(string address) where T : Object;
        UniTask<GameObject> Instantiate(string path, Vector3 at);
        UniTask<GameObject> Instantiate(string address, Transform under = null);
        void Cleanup();
    }
}
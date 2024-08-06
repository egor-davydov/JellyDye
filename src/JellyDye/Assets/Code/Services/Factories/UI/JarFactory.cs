using Code.Services.AssetManagement;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class JarFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public JarFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }
    public async UniTask<GameObject> Create(Transform parent)
    {
      GameObject jarPrefab = await _assetProvider.Load<GameObject>(AssetKey.Jar);
      GameObject colorChangeObject = _instantiator.InstantiatePrefab(jarPrefab, parent);
      
      return colorChangeObject;
    }
  }
}
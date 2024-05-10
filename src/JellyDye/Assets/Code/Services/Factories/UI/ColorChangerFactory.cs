using Code.Services.AssetManagement;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class ColorChangerFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public ColorChangerFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }
    public async UniTask<GameObject>  Create(Transform parent)
    {
      GameObject colorChangePrefab = await _assetProvider.Load<GameObject>(AssetPath.ColorChanger);
      GameObject colorChangeObject = _instantiator.InstantiatePrefab(colorChangePrefab, parent);
      
      return colorChangeObject;
    }
  }
}
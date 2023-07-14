using Code.Services.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories
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
    public GameObject Create(Transform parent)
    {
      GameObject colorChangePrefab = _assetProvider.Load(AssetPath.ColorChanger);
      GameObject colorChangeObject = _instantiator.InstantiatePrefab(colorChangePrefab, parent);
      
      return colorChangeObject;
    }
  }
}
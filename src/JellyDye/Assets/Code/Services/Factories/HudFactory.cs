using Code.Services.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories
{
  public class HudFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public HudFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }

    public GameObject CreateHud()
    {
      GameObject hudPrefab = _assetProvider.Load(AssetPath.Hud);
      GameObject hudObject = _instantiator.InstantiatePrefab(hudPrefab);

      return hudObject;
    }
  }
}
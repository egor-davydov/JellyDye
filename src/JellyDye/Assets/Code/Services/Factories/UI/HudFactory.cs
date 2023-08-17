using Code.Services.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class HudFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;
    private readonly ParentsProvider _parentsProvider;

    public HudFactory(IInstantiator instantiator, IAssetProvider assetProvider, ParentsProvider parentsProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
      _parentsProvider = parentsProvider;
    }

    public GameObject CreateHud()
    {
      GameObject hudPrefab = _assetProvider.Load(AssetPath.Hud);
      GameObject hudObject = _instantiator.InstantiatePrefab(hudPrefab, _parentsProvider.ParentForUI);

      return hudObject;
    }
  }
}
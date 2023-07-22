using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services.AssetManagement;
using Code.StaticData;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories
{
  public class SyringeFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;
    private readonly StaticDataService _staticDataService;

    public SyringeFactory(IInstantiator instantiator, IAssetProvider assetProvider, StaticDataService staticDataService)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
      _staticDataService = staticDataService;
    }

    public GameObject CreateSyringe(SkinType skinType)
    {
      GameObject syringePrefab = _staticDataService.ForSkins().SkinConfigs.Find(config => config.SkinType == skinType).SkinPrefab;
      GameObject syringeObject = _instantiator.InstantiatePrefab(syringePrefab, Vector3.up, syringePrefab.transform.rotation, new GameObject("SyringeParent").transform);
      
      return syringeObject;
    }
  }
}
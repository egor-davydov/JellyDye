using System.Linq;
using Code.Data;
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
      SkinConfig skinConfig = _staticDataService.ForSkins().SkinConfigs.Find(config => config.SkinType == skinType);
      GameObject syringeObject = _instantiator.InstantiatePrefab(skinConfig.SkinPrefab, new GameObject("SyringeParent").transform);
      
      return syringeObject;
    }
  }
}
using Code.Services.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories
{
  public class UIFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public UIFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }
    
    public GameObject CreateMainMenu()
    {
      GameObject menuPrefab = _assetProvider.Load(AssetPath.MainMenu);
      GameObject menuObject = _instantiator.InstantiatePrefab(menuPrefab, new GameObject("MenuParent").transform);
      return menuObject;
    }

    public GameObject CreateSettingsWindow()
    {
      GameObject settingsPrefab = _assetProvider.Load(AssetPath.Settings);
      GameObject settingsObject = _instantiator.InstantiatePrefab(settingsPrefab, new GameObject("SettingsParent").transform);
      return settingsObject;
    }
  }
}
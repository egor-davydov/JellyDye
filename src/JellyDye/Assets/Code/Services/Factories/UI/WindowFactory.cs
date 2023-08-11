using Code.Services.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class WindowFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public WindowFactory(IInstantiator instantiator, IAssetProvider assetProvider)
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

    public GameObject CreateFinishWindow()
    {
      GameObject finishWindowPrefab = _assetProvider.Load(AssetPath.FinishWindow);
      GameObject finishWindowObject = _instantiator.InstantiatePrefab(finishWindowPrefab, new GameObject("FinishWindowParent").transform);
      return finishWindowObject;
    }
  }
}
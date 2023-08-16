using Code.Services.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class WindowFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;
    private readonly ParentsProvider _parentsProvider;

    public WindowFactory(IInstantiator instantiator, IAssetProvider assetProvider, ParentsProvider parentsProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
      _parentsProvider = parentsProvider;
    }
    
    public GameObject CreateMainMenu()
    {
      GameObject menuPrefab = _assetProvider.Load(AssetPath.MainMenu);
      GameObject menuObject = _instantiator.InstantiatePrefab(menuPrefab, _parentsProvider.ParentForUI);
      return menuObject;
    }

    public GameObject CreateFinishWindow()
    {
      GameObject finishWindowPrefab = _assetProvider.Load(AssetPath.FinishWindow);
      GameObject finishWindowObject = _instantiator.InstantiatePrefab(finishWindowPrefab, _parentsProvider.ParentForUI);
      return finishWindowObject;
    }
  }
}
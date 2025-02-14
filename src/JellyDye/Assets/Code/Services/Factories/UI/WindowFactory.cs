using Code.Services.AssetManagement;
using Code.Services.Providers;
using Code.UI.FinishWindow;
using Code.UI.MainMenuWindow;
using Cysharp.Threading.Tasks;
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

    public async UniTask<MainMenuWindow> CreateMainMenu()
    {
      GameObject menuPrefab = await _assetProvider.Load<GameObject>(AssetKey.MainMenu);
      MainMenuWindow mainMenuWindow = _instantiator.InstantiatePrefabForComponent<MainMenuWindow>(menuPrefab, _parentsProvider.ParentForUI);
      return mainMenuWindow;
    }

    public async UniTask<FinishWindow> CreateFinishWindow()
    {
      GameObject finishWindowPrefab = await _assetProvider.Load<GameObject>(AssetKey.FinishWindow);
      FinishWindow finishWindow = _instantiator.InstantiatePrefabForComponent<FinishWindow>(finishWindowPrefab, _parentsProvider.ParentForUI);
      return finishWindow;
    }
  }
}
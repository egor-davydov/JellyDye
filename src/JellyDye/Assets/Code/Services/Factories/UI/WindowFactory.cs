using Code.Gameplay.UI.FinishWindow;
using Code.Services.AssetManagement;
using Code.Services.Providers;
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
    private readonly WindowsProvider _windowsProvider;

    public WindowFactory(IInstantiator instantiator, IAssetProvider assetProvider, ParentsProvider parentsProvider,
      WindowsProvider windowsProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
      _parentsProvider = parentsProvider;
      _windowsProvider = windowsProvider;
    }

    public async UniTask<GameObject> CreateMainMenu()
    {
      GameObject menuPrefab = await _assetProvider.Load<GameObject>(AssetKey.MainMenu);
      GameObject menuObject = _instantiator.InstantiatePrefab(menuPrefab, _parentsProvider.ParentForUI);
      _windowsProvider.MainMenu = menuObject;
      return menuObject;
    }

    public async UniTask<FinishWindow> CreateFinishWindow()
    {
      GameObject finishWindowPrefab = await _assetProvider.Load<GameObject>(AssetKey.FinishWindow);
      FinishWindow finishWindow = _instantiator.InstantiatePrefabForComponent<FinishWindow>(finishWindowPrefab, _parentsProvider.ParentForUI);
      return finishWindow;
    }
  }
}
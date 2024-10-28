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

    public WindowFactory(IInstantiator instantiator, IAssetProvider assetProvider, ParentsProvider parentsProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
      _parentsProvider = parentsProvider;
    }

    public async UniTask<GameObject> CreateMainMenu()
    {
      GameObject menuPrefab = await _assetProvider.Load<GameObject>(AssetKey.MainMenu);
      GameObject menuObject = _instantiator.InstantiatePrefab(menuPrefab, _parentsProvider.ParentForUI);
      return menuObject;
    }

    public async UniTask<GameObject> CreateFinishWindow()
    {
      GameObject finishWindowPrefab = await _assetProvider.Load<GameObject>(AssetKey.FinishWindow);
      GameObject finishWindowObject = _instantiator.InstantiatePrefab(finishWindowPrefab, _parentsProvider.ParentForUI);
      return finishWindowObject;
    }
  }
}
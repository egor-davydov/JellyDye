using Code.Services.AssetManagement;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class LevelButtonFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public LevelButtonFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }

    public async UniTask<GameObject> CreateLevelButton(Transform parent)
    {
      GameObject levelButtonPrefab = await _assetProvider.Load<GameObject>(AssetKey.LevelButton);
      GameObject menuObject = _instantiator.InstantiatePrefab(levelButtonPrefab, parent);
      return menuObject;
    }
  }
}
using Code.Services.AssetManagement;
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
    
    public GameObject CreateLevelButton(Transform parent)
    {
      GameObject levelButtonPrefab = _assetProvider.Load(AssetPath.LevelButton);
      GameObject menuObject = _instantiator.InstantiatePrefab(levelButtonPrefab, parent);
      return menuObject;
    }
  }
}
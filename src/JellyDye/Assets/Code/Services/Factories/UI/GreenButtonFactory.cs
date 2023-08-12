using Code.Gameplay.Hud;
using Code.Services.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class GreenButtonFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public GreenButtonFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }
    
    public GameObject CreateFinishButton(Transform parent)
    {
      GameObject finishButtonPrefab = _assetProvider.Load(AssetPath.FinishButton);
      GameObject finishButtonObject = _instantiator.InstantiatePrefab(finishButtonPrefab, parent);

      return finishButtonObject;
    }
    public GameObject CreateMenuButton(Transform parent)
    {
      GameObject buttonPrefab = _assetProvider.Load(AssetPath.MenuButton);
      GameObject buttonObject = _instantiator.InstantiatePrefab(buttonPrefab, parent);

      return buttonObject;
    }
  }
}
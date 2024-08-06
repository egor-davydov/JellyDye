using Code.Services.AssetManagement;
using Cysharp.Threading.Tasks;
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
    
    public async UniTask<GameObject>  CreateFinishButton(Transform parent)
    {
      GameObject finishButtonPrefab = await _assetProvider.Load<GameObject>(AssetKey.FinishButton);
      GameObject finishButtonObject = _instantiator.InstantiatePrefab(finishButtonPrefab, parent);

      return finishButtonObject;
    }
    public async UniTask<GameObject> CreateNextLevelButton(Transform parent)
    {
      GameObject buttonPrefab = await _assetProvider.Load<GameObject>(AssetKey.NextLevelButton);
      GameObject buttonObject = _instantiator.InstantiatePrefab(buttonPrefab, parent);

      return buttonObject;
    }
  }
}
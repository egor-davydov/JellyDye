using Code.Services.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories
{
  public class FinishButtonFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public FinishButtonFactory(IInstantiator instantiator, IAssetProvider assetProvider)
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
  }
}
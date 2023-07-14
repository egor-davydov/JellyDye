using Code.Services.AssetManagement;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories
{
  public class SyringeFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public SyringeFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }

    public GameObject CreateSyringe()
    {
      GameObject syringePrefab = _assetProvider.Load(AssetPath.Syringe);
      GameObject syringeObject = _instantiator.InstantiatePrefab(syringePrefab, new GameObject("SyringeParent").transform);
      
      return syringeObject;
    }
  }
}
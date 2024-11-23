using Code.Services.AssetManagement;
using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Zenject;

namespace Code.Services.Factories
{
  public class JelliesFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;
    private readonly ParentsProvider _parentsProvider;
    private readonly StaticDataService _staticData;

    public JelliesFactory(IInstantiator instantiator, IAssetProvider assetProvider, ParentsProvider parentsProvider, StaticDataService staticData)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
      _parentsProvider = parentsProvider;
      _staticData = staticData;
    }

    public async UniTask<GameObject> CreateJelly(string id)
    {
      AssetReference jelliesPrefabReference = _staticData.ForLevel(id).JelliesPrefabReference;
      GameObject jelliesPrefab = await _assetProvider.Load<GameObject>(jelliesPrefabReference);
      GameObject jelliesObject = _instantiator.InstantiatePrefab(jelliesPrefab, _parentsProvider.ParentForGameplay);
      return jelliesObject;
    }
  }
}
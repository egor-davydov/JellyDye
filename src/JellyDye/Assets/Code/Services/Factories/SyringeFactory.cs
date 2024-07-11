using System.Linq;
using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services.AssetManagement;
using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using Zenject;

namespace Code.Services.Factories
{
  public class SyringeFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;
    private readonly StaticDataService _staticDataService;
    private readonly ParentsProvider _parentsProvider;

    public SyringeFactory(IInstantiator instantiator, IAssetProvider assetProvider, StaticDataService staticDataService,
      ParentsProvider parentsProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
      _staticDataService = staticDataService;
      _parentsProvider = parentsProvider;
    }

    public async UniTask<GameObject> CreateSyringe(SkinType skinType, Vector3 at)
    {
      AssetReference skinReference = _staticDataService.ForSkins().SkinConfigs.First(config => config.SkinType == skinType).SkinReference;
      GameObject syringePrefab = await _assetProvider.Load<GameObject>(skinReference);
      GameObject syringeObject = _instantiator.InstantiatePrefab(syringePrefab, at, syringePrefab.transform.rotation, _parentsProvider.ParentForGameplay);

      return syringeObject;
    }
  }
}
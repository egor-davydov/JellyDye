using Code.Gameplay.UI.MainMenu.Skins;
using Code.Services.AssetManagement;
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

    public SyringeFactory(IInstantiator instantiator, IAssetProvider assetProvider, StaticDataService staticDataService
    )
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
      _staticDataService = staticDataService;
    }

    public async UniTask<GameObject> CreateSyringe(SkinType skinType, Vector3 at, Quaternion rotation, Transform parent)
    {
      GameObject syringeObject = await CreateSyringe(skinType, parent);
      syringeObject.transform.position = at;
      syringeObject.transform.rotation = rotation;
      return syringeObject;
    }

    public async UniTask<GameObject> CreateSyringe(SkinType skinType, Transform parent)
    {
      AssetReference skinReference = _staticDataService.ForSkins().GetSkinByType(skinType).SkinReference;
      GameObject syringePrefab = await _assetProvider.Load<GameObject>(skinReference);
      GameObject syringeObject = _instantiator.InstantiatePrefab(syringePrefab, syringePrefab.transform.position,
        syringePrefab.transform.rotation, parent);

      return syringeObject;
    }
  }
}
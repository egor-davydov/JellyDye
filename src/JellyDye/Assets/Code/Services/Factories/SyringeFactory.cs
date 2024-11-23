using Code.Gameplay.Syringe;
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

    public async UniTask<GameObject> Create(SkinType skinType, Vector3 at, Quaternion rotation, Transform parent)
    {
      GameObject syringeObject = await Create(skinType, parent);
      syringeObject.transform.position = at;
      syringeObject.transform.rotation = rotation;
      return syringeObject;
    }

    public async UniTask<GameObject> Create(SkinType skinType, Transform parent)
    {
      AssetReference syringeBaseReference = _staticDataService.Skins.SyringeBaseReference;
      GameObject syringeBasePrefab = await _assetProvider.Load<GameObject>(syringeBaseReference);
      GameObject syringeBaseObject = _instantiator.InstantiatePrefab(syringeBasePrefab,
        syringeBasePrefab.transform.position,
        syringeBasePrefab.transform.rotation, parent);

      SyringeMesh syringeMesh = await CreateMesh(skinType, syringeBaseObject.transform);
      syringeBaseObject.GetComponent<SyringePistonAndLiquid>().WireUp(syringeMesh.PistonTransform, syringeMesh.LiquidTransform);
      syringeBaseObject.GetComponent<SyringeLiquidColor>().WireUp(syringeMesh.LiquidRenderer);

      return syringeBaseObject;
    }

    public async UniTask<SyringeMesh> CreateMesh(SkinType skinType, Transform parent)
    {
      AssetReference skinReference = _staticDataService.ForSkin(skinType).SkinReference;
      GameObject syringeMeshPrefab = await _assetProvider.Load<GameObject>(skinReference);
      SyringeMesh syringeMesh = _instantiator.InstantiatePrefabForComponent<SyringeMesh>(syringeMeshPrefab, parent);
      return syringeMesh;
    }
  }
}
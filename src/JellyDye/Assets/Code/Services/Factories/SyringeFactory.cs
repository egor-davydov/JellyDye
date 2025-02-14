using Code.Enums;
using Code.Gameplay.Syringe;
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
    private readonly StaticDataService _staticData;

    public SyringeFactory(IInstantiator instantiator, IAssetProvider assetProvider, StaticDataService staticData)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
      _staticData = staticData;
    }

    public async UniTask<Syringe> Create(SkinType skinType, Vector3 at, Quaternion rotation, Transform parent)
    {
      Syringe syringe = await Create(skinType, parent);
      syringe.transform.position = at;
      syringe.transform.rotation = rotation;
      return syringe;
    }

    public async UniTask<Syringe> Create(SkinType skinType, Transform parent)
    {
      AssetReference syringeBaseReference = _staticData.ForSkins.SyringeBaseReference;
      GameObject syringeBasePrefab = await _assetProvider.Load<GameObject>(syringeBaseReference);
      Syringe syringe = _instantiator.InstantiatePrefabForComponent<Syringe>(syringeBasePrefab,
        syringeBasePrefab.transform.position,
        syringeBasePrefab.transform.rotation, parent);

      syringe.SkinType = skinType;

      SyringeMesh syringeMesh = await CreateMesh(skinType, syringe.transform);
      syringe.GetComponent<SyringePistonAndLiquid>().WireUp(syringeMesh.PistonTransform, syringeMesh.LiquidTransform);
      syringe.GetComponent<SyringeLiquidColor>().WireUp(syringeMesh.LiquidRenderer);

      return syringe;
    }

    public async UniTask<SyringeMesh> CreateMesh(SkinType skinType, Transform parent)
    {
      AssetReference skinReference = _staticData.ForSkin(skinType).SkinReference;
      GameObject syringeMeshPrefab = await _assetProvider.Load<GameObject>(skinReference);
      SyringeMesh syringeMesh = _instantiator.InstantiatePrefabForComponent<SyringeMesh>(syringeMeshPrefab, parent);
      return syringeMesh;
    }
  }
}
using Code.Services.AssetManagement;
using Code.UI.NewSkin;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class EquipNewSkinButtonFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public EquipNewSkinButtonFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }

    public async UniTask<EquipNewSkinButton> Create(Transform parent)
    {
      GameObject buttonPrefab = await _assetProvider.Load<GameObject>(AssetKey.EquipNewSkinButton);
      EquipNewSkinButton equipNewSkinButton = _instantiator.InstantiatePrefabForComponent<EquipNewSkinButton>(buttonPrefab, parent);

      return equipNewSkinButton;
    }
  }
}
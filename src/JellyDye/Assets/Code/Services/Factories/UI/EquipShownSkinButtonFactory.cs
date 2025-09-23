using Code.Services.AssetManagement;
using Code.UI.SkinShow;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class EquipShownSkinButtonFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public EquipShownSkinButtonFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }

    public async UniTask<EquipShownSkinButton> Create(Transform parent)
    {
      GameObject buttonPrefab = await _assetProvider.Load<GameObject>(AssetKey.EquipNewSkinButton);
      EquipShownSkinButton equipShownSkinButton = _instantiator.InstantiatePrefabForComponent<EquipShownSkinButton>(buttonPrefab, parent);

      return equipShownSkinButton;
    }
  }
}
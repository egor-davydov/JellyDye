using System.Threading.Tasks;
using Code.Services.AssetManagement;
using Code.Services.Providers;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class HudFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;
    private readonly ParentsProvider _parentsProvider;

    public HudFactory(IInstantiator instantiator, IAssetProvider assetProvider,
      ParentsProvider parentsProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
      _parentsProvider = parentsProvider;
    }

    public async UniTask<GameObject> CreateHud()
    {
      GameObject hudPrefab = await _assetProvider.Load<GameObject>(AssetKey.Hud);
      GameObject hudObject = _instantiator.InstantiatePrefab(hudPrefab, _parentsProvider.ParentForUI);

      return hudObject;
    }
  }
}
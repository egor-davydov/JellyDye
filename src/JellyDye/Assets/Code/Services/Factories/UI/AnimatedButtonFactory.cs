using Code.Services.AssetManagement;
using Code.UI;
using Code.UI.SkinShow;
using Cysharp.Threading.Tasks;
using UnityEngine;
using Zenject;

namespace Code.Services.Factories.UI
{
  public class AnimatedButtonFactory
  {
    private readonly IInstantiator _instantiator;
    private readonly IAssetProvider _assetProvider;

    public AnimatedButtonFactory(IInstantiator instantiator, IAssetProvider assetProvider)
    {
      _instantiator = instantiator;
      _assetProvider = assetProvider;
    }

    public async UniTask<CloseSkinShowButton> CreateCloseSkinButton(Transform parent, bool animate = true)
    {
      GameObject buttonPrefab = await _assetProvider.Load<GameObject>(AssetKey.CloseSkinButton);
      AnimatedButton animatedButton = _instantiator.InstantiatePrefabForComponent<AnimatedButton>(buttonPrefab, parent);
      if (animate)
        animatedButton.Animate();
      else
        animatedButton.SetFinishPosition();

      return animatedButton.GetComponent<CloseSkinShowButton>();
    }
  }
}
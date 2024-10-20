using Code.Gameplay.UI;
using Code.Services.AssetManagement;
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

    public async UniTask<AnimatedButton> CreateFinishButton(Transform parent)
    {
      GameObject buttonPrefab = await _assetProvider.Load<GameObject>(AssetKey.FinishButton);
      AnimatedButton animatedButton = _instantiator.InstantiatePrefabForComponent<AnimatedButton>(buttonPrefab, parent);
      animatedButton.Animate();

      return animatedButton;
    }

    public async UniTask<AnimatedButton> CreateNextLevelButton(Transform parent)
    {
      GameObject buttonPrefab = await _assetProvider.Load<GameObject>(AssetKey.NextLevelButton);
      AnimatedButton animatedButton = _instantiator.InstantiatePrefabForComponent<AnimatedButton>(buttonPrefab, parent);
      animatedButton.Animate();

      return animatedButton;
    }

    public async UniTask<AnimatedButton> CreateCloseSkinButton(Transform parent, bool animate = true)
    {
      GameObject buttonPrefab = await _assetProvider.Load<GameObject>(AssetKey.CloseSkinButton);
      AnimatedButton animatedButton = _instantiator.InstantiatePrefabForComponent<AnimatedButton>(buttonPrefab, parent);
      if (animate)
        animatedButton.Animate();
      else
        animatedButton.SetFinishPosition();

      return animatedButton;
    }
  }
}
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Code.Gameplay.UI
{
  public class AnimatedButton : MonoBehaviour
  {
    [SerializeField] private float _moveTime;

    private RectTransform _rectTransform;
    private TweenerCore<Vector2, Vector2, VectorOptions> _tween;

    private void Awake()
    {
      _rectTransform = ((RectTransform)transform);
      _tween = _rectTransform.DOAnchorPos(Vector2.zero, _moveTime).SetEase(Ease.OutQuad)
        .SetAutoKill(false);
    }

    public void Animate() =>
      _tween.Restart();

    public void ResetAnimation() =>
      _tween.Rewind();

    public void SetFinishPosition() =>
      _tween.Complete();

    private void OnDestroy() =>
      _tween.Kill();
  }
}
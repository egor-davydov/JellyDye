using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

namespace Code.Gameplay.Syringe
{
  public class SyringeAnimation : MonoBehaviour
  {
    [SerializeField, Range(0, 0.5f)] private float _movingCloserDistance;
    [SerializeField, Range(0, 0.2f)] private float _movingLittleBackDistance;
    [SerializeField] private Ease _moveCloserEase;
    [SerializeField] private Ease _moveLittleBackEase;
    [SerializeField] private float _movingCloserTime;
    [SerializeField] private float _movingLittleBackTime;
    [SerializeField] private float _movingBackTime;

    private Vector3 _movingCloserDirection;
    private Tween _moveTween;
    public bool IsPlaying { get; private set; }

    private void Awake()
    {
      _movingCloserDirection = transform.localRotation * Vector3.down;
    }

    public void StopAnimation() =>
      _moveTween.Kill();

    public void AnimateInjection(TweenCallback onComplete = null)
    {
      TweenerCore<Vector3, Vector3, VectorOptions> moveCloserTween =
        transform.DOMove(transform.position + _movingCloserDirection * _movingCloserDistance, _movingCloserTime).SetEase(_moveCloserEase);
      Tween injectionAnimation = DOTween.Sequence()
        .Append(moveCloserTween)
        .Append(transform.DOMove(moveCloserTween.endValue - _movingCloserDirection * _movingLittleBackDistance,
          _movingLittleBackTime).SetEase(_moveLittleBackEase)).OnComplete(onComplete);
      _moveTween = injectionAnimation;
    }

    public void AnimateMovingBack(Vector3 injectionStartPosition)
    {
      IsPlaying = true;
      _moveTween = transform.DOMove(injectionStartPosition, _movingBackTime).OnComplete(() => IsPlaying = false);
    }
  }
}
using System.Threading;
using Code.Extensions;
using Cysharp.Threading.Tasks;
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

    private CancellationTokenSource _cts;
    private Vector3 _movingCloserDirection;
    private TweenerCore<Vector3, Vector3, VectorOptions> _moveCloserTween;
    private TweenerCore<Vector3, Vector3, VectorOptions> _moveLittleBackTween;
    private TweenerCore<Vector3, Vector3, VectorOptions> _moveBackTween;

    private bool IsInjectionPlaying => _moveCloserTween.IsPlaying() || _moveLittleBackTween.IsPlaying();

    private void Awake()
    {
      _cts = new CancellationTokenSource();
      _movingCloserDirection = transform.localRotation * Vector3.down;

      _moveCloserTween = transform.DOMove(default, _movingCloserTime)
        .SetEase(_moveCloserEase).SetLink(gameObject).SetAutoKill(false);

      _moveLittleBackTween = transform.DOMove(default, _movingLittleBackTime)
        .SetEase(_moveLittleBackEase).SetLink(gameObject).SetAutoKill(false);

      _moveBackTween = transform.DOMove(default, _movingBackTime)
        .SetLink(gameObject).SetAutoKill(false);
    }

    public void CompleteMoveBackIfPlaying()
    {
      if (_moveBackTween.IsPlaying())
        _moveBackTween.Complete();
    }

    public async UniTask AwaitAnimateInjectionComplete()
    {
      Vector3 movingCloserEnd = transform.position + _movingCloserDirection * _movingCloserDistance;
      _moveCloserTween.ChangeValues(transform.position, movingCloserEnd);
      _moveLittleBackTween.ChangeValues(movingCloserEnd, movingCloserEnd - _movingCloserDirection * _movingLittleBackDistance);

      await RestartAndAwaitTweenComplete(_moveCloserTween);
      await RestartAndAwaitTweenComplete(_moveLittleBackTween);
    }

    public async UniTaskVoid AnimateMovingBack(Vector3 injectionStartPosition)
    {
      _moveBackTween.ChangeValues(transform.position, injectionStartPosition);
      await RestartAndAwaitTweenComplete(_moveBackTween);
    }

    public void StopInjectionAnimationIfPlaying()
    {
      if (!IsInjectionPlaying)
        return;

      _cts.Cancel();
      _cts = new CancellationTokenSource();
      _moveCloserTween.Pause();
      _moveLittleBackTween.Pause();
    }

    private UniTask RestartAndAwaitTweenComplete(Tween tween) =>
      tween.RestartAndAwaitComplete(TweenCancelBehaviour.CancelAwait, _cts.Token);
  }
}
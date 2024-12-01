using System;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class LevelCamera : MonoBehaviour
  {
    private const Ease MoveEase = Ease.OutQuad;

    [field: SerializeField] public Camera Camera { get; private set; }
    [field: SerializeField] public float MovingTime { get; private set; }
    [SerializeField] private Vector3 _finishPosition;
    [SerializeField] private Vector3 _finishRotation;
    [SerializeField] private float _finishOrthoSize;
    [SerializeField] private float _flashDuration;
    [SerializeField] private Light _flashLight;
    [SerializeField] private AudioSource _photoAudioSource;
    [SerializeField] private AudioClip _photoSound;

    private Sequence _finishSequence;

    private void Awake()
    {
      Tween moveTween = transform.DOMove(_finishPosition, MovingTime).SetEase(MoveEase);
      Tween rotateTween = transform.DORotate(_finishRotation, MovingTime).SetEase(MoveEase);
      Tween orthoSizeTween = Camera.DOOrthoSize(_finishOrthoSize, MovingTime).SetEase(MoveEase);
      _finishSequence = DOTween.Sequence()
        .Join(moveTween)
        .Join(rotateTween)
        .Join(orthoSizeTween)
        .SetAutoKill(false);
    }

    public void OnDestroy() =>
      _finishSequence.Kill();

    public void MoveToStart() =>
      _finishSequence.Rewind();

    public async UniTask MoveToFinishAsync()
    {
      _finishSequence.Restart();
      await _finishSequence.AwaitForComplete();
    }

    public void MoveToFinish() =>
      _finishSequence.Complete();

    public async UniTask ShowPhotoFlash()
    {
      _photoAudioSource.PlayOneShot(_photoSound);
      GameObject flashObject = _flashLight.gameObject;
      flashObject.SetActive(true);
      await UniTask.Delay(TimeSpan.FromSeconds(_flashDuration));
      flashObject.SetActive(false);
    }
  }
}
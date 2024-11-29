using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class LevelCamera : MonoBehaviour
  {
    private const Ease MoveEase = Ease.Linear;

    [field: SerializeField] public float FlashDuration { get; private set; }
    [field: SerializeField] public Light FlashLight { get; private set; }
    [field: SerializeField] public Camera Camera { get; private set; }
    [field: SerializeField] public Vector3 FinishPosition { get; private set; }
    [field: SerializeField] public Vector3 FinishRotation { get; private set; }
    [field: SerializeField] public float MovingTime { get; private set; }
    [field: SerializeField] public float TargetSize { get; private set; }
    [SerializeField] private AudioSource _photoAudioSource;
    [SerializeField] private AudioClip _photoSound;

    private Tween _moveTween;
    private Tween _rotateTween;
    private Tween _orthoSizeTween;

    public void OnDestroy()
    {
      _moveTween.Kill();
      _rotateTween.Kill();
      _orthoSizeTween.Kill();
    }

    public async UniTask MoveToFinish()
    {
      _moveTween = transform.DOMove(FinishPosition, MovingTime).SetEase(MoveEase).Play();
      _rotateTween = transform.DORotate(FinishRotation, MovingTime).SetEase(MoveEase).Play();
      _orthoSizeTween = Camera.DOOrthoSize(TargetSize, MovingTime).SetEase(MoveEase).Play();
      await _orthoSizeTween;
    }

    public void PlayPhotoSound()
    {
      _photoAudioSource.PlayOneShot(_photoSound);
    }
  }
}
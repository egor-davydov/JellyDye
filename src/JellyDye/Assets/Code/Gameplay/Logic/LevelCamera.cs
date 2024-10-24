using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Code.Gameplay.Logic
{
  public class LevelCamera : MonoBehaviour
  {
    private const Ease MoveEase = Ease.OutQuad;
    [field: SerializeField] public float FlashDuration { get; private set; }
    [field: SerializeField] public Light FlashLight { get; private set; }
    [SerializeField] private Camera _camera;
    [SerializeField] private Vector3 _finishPosition;
    [SerializeField] private Vector3 _finishRotation;
    [SerializeField] private float _movingTime;
    [SerializeField] private float _targetSize;
    [SerializeField] private AudioSource _photoAudioSource;
    [SerializeField] private AudioClip _photoSound;

    public float TargetSize => _targetSize;
    public Camera Camera => _camera;
    public float MovingTime => _movingTime;
    public Vector3 FinishPosition => _finishPosition;
    public Vector3 FinishRotation => _finishRotation;
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
      _moveTween = transform.DOMove(FinishPosition, _movingTime).SetEase(MoveEase);
      _rotateTween = transform.DORotate(FinishRotation, _movingTime).SetEase(MoveEase);
      _orthoSizeTween = Camera.DOOrthoSize(TargetSize, _movingTime).SetEase(MoveEase);
      await _orthoSizeTween;
    }

    public void PlayPhotoSound()
    {
      _photoAudioSource.PlayOneShot(_photoSound);
    }
  }
}
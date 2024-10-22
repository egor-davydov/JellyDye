using System;
using Code.Gameplay.Logic;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Code.Services
{
  public class CameraService : IDisposable
  {
    private readonly AudioService _audioService;
    private Tween _moveTween;
    private Tween _rotateTween;

    public LevelCamera LevelCamera { get; private set; }

    public CameraService(AudioService audioService)
    {
      _audioService = audioService;
    }

    public void Initialize(LevelCamera levelCamera)
    {
      LevelCamera = levelCamera;
    }

    public void Dispose()
    {
      _moveTween.Kill();
      _rotateTween.Kill();
    }

    public async UniTask MoveToFinish()
    {
      _moveTween = LevelCamera.transform.DOMove(LevelCamera.FinishPosition, LevelCamera.MovingTime);
      _rotateTween = LevelCamera.transform.DORotate(LevelCamera.FinishRotation, LevelCamera.MovingTime);
      await ResizeCamera();
    }

    public async UniTask ShowPhotoFlash()
    {
      LevelCamera.PhotoAudioSource.PlayOneShot(LevelCamera.PhotoSound);
      GameObject flashObject = LevelCamera.FlashLight.gameObject;
      flashObject.SetActive(true);
      await UniTask.Delay(TimeSpan.FromSeconds(LevelCamera.FlashDuration));
      flashObject.SetActive(false);
    }

    private async UniTask ResizeCamera()
    {
      float currentTime = 0;
      while (currentTime < LevelCamera.MovingTime)
      {
        LevelCamera.Camera.orthographicSize = Mathf.Lerp(
          LevelCamera.Camera.orthographicSize,
          LevelCamera.TargetSize,
          currentTime / LevelCamera.MovingTime);

        currentTime += Time.deltaTime;
        await UniTask.NextFrame();
      }

      LevelCamera.Camera.orthographicSize = LevelCamera.TargetSize;
    }
  }
}
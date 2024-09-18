using System;
using System.Collections;
using Code.Gameplay.Logic;
using Code.Infrastructure;
using DG.Tweening;
using UnityEngine;

namespace Code.Services
{
  public class CameraService : IDisposable
  {
    private readonly ICoroutineRunner _coroutineRunner;
    private readonly AudioService _audioService;
    private Tween _moveTween;
    private Tween _rotateTween;
    
    public LevelCamera LevelCamera { get; private set; }

    public CameraService(ICoroutineRunner coroutineRunner, AudioService audioService)
    {
      _coroutineRunner = coroutineRunner;
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

    public Tween MoveToFinish()
    {
      _moveTween = LevelCamera.transform.DOMove(LevelCamera.FinishPosition, LevelCamera.MovingTime);
      _rotateTween = LevelCamera.transform.DORotate(LevelCamera.FinishRotation, LevelCamera.MovingTime);
      _coroutineRunner.StartCoroutine(ResizeCamera());
      return _moveTween;
    }

    public void ShowPhotoFlash(Action onFlashEnd = null)
    {
      _coroutineRunner.StartCoroutine(ShowFlash(onFlashEnd));
    }

    private IEnumerator ShowFlash(Action onFlashEnd)
    {
      if(!_audioService.IsAudioMuted)
        LevelCamera.PhotoAudioSource.Play();
      GameObject flashObject = LevelCamera.FlashLight.gameObject;
      flashObject.SetActive(true);
      yield return new WaitForSeconds(LevelCamera.FlashDuration);
      flashObject.SetActive(false);
      onFlashEnd?.Invoke();
    }

    private IEnumerator ResizeCamera()
    {
      float currentTime = 0;
      while (currentTime < LevelCamera.MovingTime)
      {
        LevelCamera.Camera.orthographicSize = Mathf.Lerp(
          LevelCamera.Camera.orthographicSize,
          LevelCamera.TargetSize,
          currentTime / LevelCamera.MovingTime);

        currentTime += Time.deltaTime;
        yield return null;
      }

      LevelCamera.Camera.orthographicSize = LevelCamera.TargetSize;
    }
  }
}
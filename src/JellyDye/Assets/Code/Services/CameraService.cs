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
    private LevelCamera _levelCamera;
    private readonly ICoroutineRunner _coroutineRunner;
    private Tween _moveTween;
    private Tween _rotateTween;

    public CameraService(ICoroutineRunner coroutineRunner)
    {
      _coroutineRunner = coroutineRunner;
    }

    public void Initialize(LevelCamera levelCamera)
    {
      _levelCamera = levelCamera;
    }

    public void Dispose()
    {
      _moveTween.Kill();
      _rotateTween.Kill();
    }

    public Tween MoveToFinish()
    {
      _moveTween = _levelCamera.transform.DOMove(_levelCamera.FinishPosition, _levelCamera.MovingTime);
      _rotateTween = _levelCamera.transform.DORotate(_levelCamera.FinishRotation, _levelCamera.MovingTime);
      _coroutineRunner.StartCoroutine(ResizeCamera());
      return _moveTween;
    }

    private IEnumerator ResizeCamera()
    {
      float currentTime = 0;
      while (currentTime < _levelCamera.MovingTime)
      {
        _levelCamera.Camera.orthographicSize = Mathf.Lerp(
          _levelCamera.Camera.orthographicSize,
          _levelCamera.TargetSize,
          currentTime / _levelCamera.MovingTime);
        
        currentTime += Time.deltaTime;
        yield return null;
      }

      _levelCamera.Camera.orthographicSize = _levelCamera.TargetSize;
    }
  }
}
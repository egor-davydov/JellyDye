using System;
using Code.Gameplay.Logic;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Code.Services
{
  public class CameraService
  {
    public LevelCamera LevelCamera { get; private set; }

    public void Initialize(LevelCamera levelCamera)
    {
      LevelCamera = levelCamera;
    }

    public async UniTask MoveToFinish()
    {
      await LevelCamera.MoveToFinish();
    }

    public async UniTask ShowPhotoFlash()
    {
      LevelCamera.PlayPhotoSound();
      GameObject flashObject = LevelCamera.FlashLight.gameObject;
      flashObject.SetActive(true);
      await UniTask.Delay(TimeSpan.FromSeconds(LevelCamera.FlashDuration));
      flashObject.SetActive(false);
    }
  }
}
﻿using System.Collections.Generic;
using System.Linq;
using Code.Services;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;
using Zenject;

namespace Code.Gameplay.Logic.UI
{
  public class LevelLoadingFill : MonoBehaviour
  {
    [SerializeField] private Image _loadingFillImage;

    private SceneLoader _sceneLoader;

    [Inject]
    public void Construct(SceneLoader sceneLoader)
    {
      _sceneLoader = sceneLoader;
    }

    public async UniTaskVoid StartFill(List<AsyncOperationHandle> loadingOperations)
    {
      while (true)
      {
        _loadingFillImage.fillAmount = (loadingOperations.Sum(x => x.PercentComplete) / loadingOperations.Count + _sceneLoader.LoadProgress) / 2;
        await UniTask.NextFrame(this.GetCancellationTokenOnDestroy());
      }
    }
  }
}
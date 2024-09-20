using System;
using System.Collections;
using Code.Gameplay.Logic;
using Code.Infrastructure;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class SceneLoader
  {
    public float LoadProgress { get; private set; }

    public async UniTask StartLoad(string loadId)
    {
      LoadProgress = 0;
      AsyncOperation loadSceneAsync = SceneManager.LoadSceneAsync(loadId);
      loadSceneAsync.priority = 999;

      while (!loadSceneAsync.isDone)
      {
        LoadProgress = loadSceneAsync.progress;
        await UniTask.NextFrame();
      }
    }
  }
}
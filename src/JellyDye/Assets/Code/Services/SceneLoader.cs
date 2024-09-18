using System;
using System.Collections;
using Code.Gameplay.Logic;
using Code.Infrastructure;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class SceneLoader
  {
    private readonly ICoroutineRunner _coroutineRunner;

    public float LoadProgress { get; private set; }

    public SceneLoader(ICoroutineRunner coroutineRunner) => 
      _coroutineRunner = coroutineRunner;

    public void StartLoad(string loadId, Action onComplete = null)
    {
      LoadProgress = 0;
      _coroutineRunner.StartCoroutine(SceneLoading(loadId, onComplete));
    }

    private IEnumerator SceneLoading(string loadId, Action onComplete = null)
    {
      AsyncOperation loadSceneAsync = SceneManager.LoadSceneAsync(loadId);
      loadSceneAsync.priority = 999;

      while (!loadSceneAsync.isDone)
      {
        LoadProgress = loadSceneAsync.progress;
        yield return null;
      }

      onComplete?.Invoke();
    }
  }
}
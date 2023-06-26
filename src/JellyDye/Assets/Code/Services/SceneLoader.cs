using System;
using System.Collections;
using Code.Infrastructure;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class SceneLoader
  {
    private readonly ICoroutineRunner _coroutineRunner;

    public SceneLoader(ICoroutineRunner coroutineRunner) => 
      _coroutineRunner = coroutineRunner;

    public void StartLoad(string sceneName, Action onComplete = null) => 
      _coroutineRunner.StartCoroutine(SceneLoading(sceneName, onComplete));

    private IEnumerator SceneLoading(string sceneName, Action onComplete = null)
    {
      AsyncOperation loadSceneAsync = SceneManager.LoadSceneAsync(sceneName);

      while (!loadSceneAsync.isDone)
        yield return null;

      onComplete?.Invoke();
    }
  }
}
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
    private readonly LoadingCurtain _loadingCurtain;

    public SceneLoader(ICoroutineRunner coroutineRunner, LoadingCurtain loadingCurtain)
    {
      _coroutineRunner = coroutineRunner;
      _loadingCurtain = loadingCurtain;
    }

    public void StartLoad(string sceneName, Action onComplete = null) => 
      _coroutineRunner.StartCoroutine(SceneLoading(sceneName, onComplete));

    private IEnumerator SceneLoading(string sceneName, Action onComplete = null)
    {
      AsyncOperation loadSceneAsync = SceneManager.LoadSceneAsync(sceneName);

      while (!loadSceneAsync.isDone)
      {
        _loadingCurtain.FillLoadingProgress(loadSceneAsync.progress);
        yield return null;
      }

      onComplete?.Invoke();
    }
  }
}
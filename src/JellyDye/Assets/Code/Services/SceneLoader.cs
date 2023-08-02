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

    public void StartLoad(int index, Action onComplete = null) => 
      _coroutineRunner.StartCoroutine(SceneLoading(index, onComplete));

    private IEnumerator SceneLoading(int index, Action onComplete = null)
    {
      AsyncOperation loadSceneAsync = SceneManager.LoadSceneAsync(index);

      while (!loadSceneAsync.isDone)
      {
        //_loadingCurtain.FillLoadingProgress(loadSceneAsync.progress);
        yield return null;
      }

      onComplete?.Invoke();
    }
  }
}
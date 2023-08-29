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

    public void StartLoad(int index, Action onComplete = null) => 
      _coroutineRunner.StartCoroutine(SceneLoading(index, onComplete));

    private IEnumerator SceneLoading(int index, Action onComplete = null)
    {
      AsyncOperation loadSceneAsync = SceneManager.LoadSceneAsync(index);

      while (!loadSceneAsync.isDone)
      {
        LoadProgress = loadSceneAsync.progress;
        yield return null;
      }

      onComplete?.Invoke();
    }
  }
}
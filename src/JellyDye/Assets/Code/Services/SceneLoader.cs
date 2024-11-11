using System;
using Cysharp.Threading.Tasks;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace Code.Services
{
  public class SceneLoader
  {
    public float LoadProgress { get; private set; }

    public async UniTask<SceneInstance> Load(string loadId, LoadSceneMode loadMode = LoadSceneMode.Single)
    {
      LoadProgress = 0;
      AsyncOperationHandle<SceneInstance> loadSceneAsync = Addressables.LoadSceneAsync(loadId, loadMode);

      while (!loadSceneAsync.IsDone)
      {
        LoadProgress = loadSceneAsync.PercentComplete;
        await UniTask.NextFrame(PlayerLoopTiming.LastUpdate);
      }

      return loadSceneAsync.Result;
    }
  }

  class MyClass : IProgress<float>
  {
    public void Report(float value)
    {
    }
  }
}
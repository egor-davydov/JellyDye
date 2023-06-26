using Code.Services;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Code.Infrastructure.States
{
  public class LoadLevelState : IPayloadState<string>
  {
    private readonly SceneLoader _sceneLoader;

    public LoadLevelState(SceneLoader sceneLoader)
    {
      _sceneLoader = sceneLoader;
    }
    
    public void Enter(string sceneName)
    {
      Debug.Log($"Enter LoadLevelState LoadingSceneName: '{sceneName}'");
      _sceneLoader.StartLoad(sceneName, OnLoadComplete);
    }

    public void Exit()
    {
      
    }

    private void OnLoadComplete()
    {
      Debug.Log($"OnLoadComplete LoadLevelState ActiveScene: '{SceneManager.GetActiveScene().name}'");

    }
  }
}
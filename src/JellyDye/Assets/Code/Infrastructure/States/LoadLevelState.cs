using Code.Gameplay.Logic;
using Code.Infrastructure.Installers;
using Code.Services;
using UnityEngine;

namespace Code.Infrastructure.States
{
  public class LoadLevelState : IPayloadState<string>
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly SceneLoader _sceneLoader;
    private readonly LoadingCurtain _loadingCurtain;

    public LoadLevelState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, LoadingCurtain loadingCurtain)
    {
      _gameStateMachine = gameStateMachine;
      _sceneLoader = sceneLoader;
      _loadingCurtain = loadingCurtain;
    }
    
    public void Enter(string sceneName)
    {
      _loadingCurtain.Show();
      Debug.Log($"Enter LoadLevelState LoadingSceneName: '{sceneName}'");
      _sceneLoader.StartLoad(sceneName, OnLoadComplete);
    }

    public void Exit() => 
      _loadingCurtain.Hide();

    private void OnLoadComplete()
    {
      _gameStateMachine.Enter<GameLoopState>();
    }
  }
}
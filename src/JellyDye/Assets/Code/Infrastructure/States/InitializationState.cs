using System.Runtime.InteropServices;
using Code.Services;
#if !UNITY_EDITOR && UNITY_WEBGL
using CrazyGames;
using UnityEngine;
#endif

namespace Code.Infrastructure.States
{
  public class InitializationState : IState
  {
    private const string LoadSceneName = "Load";
    
    private readonly GameStateMachine _gameStateMachine;
    private readonly StaticDataService _staticDataService;
    private readonly PublishService _publishService;
    private readonly SceneLoader _sceneLoader;

    [DllImport("__Internal")]
    private static extern void WebDebugLog(string log);

    public InitializationState(GameStateMachine gameStateMachine, StaticDataService staticDataService,
      PublishService publishService, SceneLoader sceneLoader)
    {
      _gameStateMachine = gameStateMachine;
      _staticDataService = staticDataService;
      _publishService = publishService;
      _sceneLoader = sceneLoader;
    }

    public void Enter()
    {
      _staticDataService.LoadData();
#if !UNITY_EDITOR && UNITY_WEBGL
      WebDebugLog($"IsOnCrazyGames={CrazySDK.IsOnCrazyGames}");
      WebDebugLog($"Application.absoluteURL={Application.absoluteURL}");
#endif
      if (_publishService.IsOnYandexGames())
        _publishService.InitializeYandex(OnSdkInitialize, OnPlayerInitialized);
      else
        OnPlayerInitialized();
    }

    public void Exit()
    {
    }

    private void OnPlayerInitialized() =>
      MoveToNextState();

    private void OnSdkInitialize() => 
      _sceneLoader.StartLoad(LoadSceneName);

    private void MoveToNextState() =>
      _gameStateMachine.Enter<LoadProgressState>();
  }
}
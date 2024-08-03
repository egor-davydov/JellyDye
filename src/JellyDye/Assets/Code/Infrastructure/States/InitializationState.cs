using System.Runtime.InteropServices;
using Code.Services;
using Code.Services.AssetManagement;
using Code.StaticData;
using Code.StaticData.Level;
using UnityEngine;
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
    private readonly IAssetProvider _assetProvider;

    [DllImport("__Internal")]
    private static extern void WebDebugLog(string log);

    public InitializationState(GameStateMachine gameStateMachine, StaticDataService staticDataService,
      PublishService publishService, SceneLoader sceneLoader, IAssetProvider assetProvider)
    {
      _gameStateMachine = gameStateMachine;
      _staticDataService = staticDataService;
      _publishService = publishService;
      _sceneLoader = sceneLoader;
      _assetProvider = assetProvider;
    }

    public void Enter()
    {
      _staticDataService.LoadData();
      foreach (LevelConfig levelConfig in _staticDataService.ForLevels().LevelConfigs)
      {
        foreach (JellyMeshConfig jellyMeshConfig in levelConfig.JellyMeshConfigs)
          _assetProvider.Load<Mesh>(jellyMeshConfig.MeshReference);
      }
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
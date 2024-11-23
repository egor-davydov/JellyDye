﻿using Code.Infrastructure.States.Interfaces;
using Code.Services;
using Code.Services.AssetManagement;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States
{
  public class InitializationState : IState
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly StaticDataService _staticData;
    private readonly PublishService _publishService;
    private readonly IAssetProvider _assetProvider;

    public InitializationState(GameStateMachine gameStateMachine, StaticDataService staticDataService,
      PublishService publishService, IAssetProvider assetProvider)
    {
      _gameStateMachine = gameStateMachine;
      _staticData = staticDataService;
      _publishService = publishService;
      _assetProvider = assetProvider;
    }

    public UniTaskVoid Enter()
    {
      _staticData.Initialize();
      _assetProvider.Initialize();
      // WebDebug.Log($"IsOnCrazyGames={CrazySDK.IsOnCrazyGames}");
      // WebDebug.Log($"Application.absoluteURL={Application.absoluteURL}");
      _publishService.Initialize(OnSdkInitialize, OnPlayerInitialized);
      return default;
    }

    public UniTaskVoid Exit()
    {
      return default;
    }

    private void OnPlayerInitialized()
    {
      MoveToNextState();
    }

    private void OnSdkInitialize()
    {
    }

    private void MoveToNextState() =>
      _gameStateMachine.Enter<LoadProgressState>();
  }
}
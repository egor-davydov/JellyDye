﻿using System.Runtime.InteropServices;
using Code.Services;
#if !UNITY_EDITOR && UNITY_WEBGL
using CrazyGames;
using UnityEngine;
#endif

namespace Code.Infrastructure.States
{
  public class InitializationState : IState
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly StaticDataService _staticDataService;
    private readonly PublishService _publishService;

    [DllImport("__Internal")]
    private static extern void WebDebugLog(string log);

    public InitializationState(GameStateMachine gameStateMachine, StaticDataService staticDataService,
      PublishService publishService)
    {
      _gameStateMachine = gameStateMachine;
      _staticDataService = staticDataService;
      _publishService = publishService;
    }

    public void Enter()
    {
      _staticDataService.LoadData();
#if !UNITY_EDITOR && UNITY_WEBGL
      WebDebugLog($"IsOnCrazyGames={CrazySDK.IsOnCrazyGames}");
      WebDebugLog($"Application.absoluteURL={Application.absoluteURL}");
#endif
      if (_publishService.IsOnYandexGames())
        _publishService.InitializeYandex(onPlayerInitialize: OnPlayerInitialized);
      else
        OnPlayerInitialized();
    }

    public void Exit()
    {
    }

    private void InvokeOnInitialize()
    {
      _publishService.InvokeOnSdkInitialize();
      OnPlayerInitialized();
    }

    private void OnPlayerInitialized() =>
      MoveToNextState();

    private void MoveToNextState() =>
      _gameStateMachine.Enter<LoadProgressState>();
  }
}
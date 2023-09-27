#if !UNITY_EDITOR && UNITY_WEBGL
using System;
using System.Runtime.InteropServices;
using Code.StaticServices;
#endif
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;

namespace Code.Infrastructure.States
{
  public class LoadProgressState : IState
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly ProgressService _progressService;
    private readonly ISaveLoadService _saveLoadService;

#if !UNITY_EDITOR && UNITY_WEBGL
    [DllImport("__Internal")]
    private static extern bool IsYandexGames();

    [DllImport("__Internal")]
    private static extern void GameReadyToPLay();

    [DllImport("__Internal")]
    private static extern void ShowFullscreenAdv(Action onOpen, Action onClose);
#endif
    public LoadProgressState(GameStateMachine gameStateMachine, ProgressService progressService, ISaveLoadService saveLoadService)
    {
      _gameStateMachine = gameStateMachine;
      _progressService = progressService;
      _saveLoadService = saveLoadService;
    }

    public void Enter()
    {
      _saveLoadService.LoadProgressAsync(onLoaded: MoveToNextState);
    }

    public void Exit()
    {
    }

    private void MoveToNextState()
    {
      _gameStateMachine.Enter<LoadLevelState, int>(_progressService.Progress.LevelData.CurrentLevelIndex);
#if !UNITY_EDITOR && UNITY_WEBGL
      if (IsYandexGames())
      {
        GameReadyToPLay();
        ShowFullscreenAdv(FullscreenAdvStaticService.OnOpen, FullscreenAdvStaticService.OnClose);
      }
#endif
    }
  }
}
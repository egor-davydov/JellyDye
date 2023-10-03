using Code.Services;
using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;

namespace Code.Infrastructure.States
{
  public class LoadProgressState : IState
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly ProgressService _progressService;
    private readonly ISaveLoadService _saveLoadService;
    private readonly YandexService _yandexService;

    public LoadProgressState(GameStateMachine gameStateMachine, ProgressService progressService,
      ISaveLoadService saveLoadService, YandexService yandexService)
    {
      _gameStateMachine = gameStateMachine;
      _progressService = progressService;
      _saveLoadService = saveLoadService;
      _yandexService = yandexService;
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
      _yandexService.ShowFullscreenAdv();
      _gameStateMachine.Enter<LoadLevelState, string>(_progressService.Progress.LevelData.CurrentLevelId);
    }
  }
}
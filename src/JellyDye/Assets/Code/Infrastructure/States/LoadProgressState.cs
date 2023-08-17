using Code.Services.Progress;
using Code.Services.Progress.SaveLoad;

namespace Code.Infrastructure.States
{
  public class LoadProgressState : IState
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly ProgressService _progressService;
    private readonly ISaveLoadService _saveLoadService;

    public LoadProgressState(GameStateMachine gameStateMachine, ProgressService progressService, ISaveLoadService saveLoadService)
    {
      _gameStateMachine = gameStateMachine;
      _progressService = progressService;
      _saveLoadService = saveLoadService;
    }

    public void Enter()
    {
      if (_saveLoadService.IsPlayerHaveProgress())
        _progressService.SetProgress(_saveLoadService.LoadProgress());
      else
        _progressService.CreateProgress();
      
      _gameStateMachine.Enter<LoadLevelState, int>(_progressService.Progress.LevelData.CurrentLevelIndex);
    }

    public void Exit()
    {
    }
  }
}
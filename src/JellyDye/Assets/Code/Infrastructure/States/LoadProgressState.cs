using Code.Services.Progress;

namespace Code.Infrastructure.States
{
  public class LoadProgressState : IState
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly ProgressService _progressService;

    public LoadProgressState(GameStateMachine gameStateMachine, ProgressService progressService)
    {
      _gameStateMachine = gameStateMachine;
      _progressService = progressService;
    }
    
    public void Enter()
    {
      _progressService.CreateProgress();
      _gameStateMachine.Enter<LoadLevelState, int>(0);
    }

    public void Exit()
    {
      
    }
  }
}
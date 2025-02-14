using Code.Infrastructure.States.Interfaces;
using Code.Services.Progress.SaveLoad;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States
{
  public class LoadProgressState : IState
  {
    private readonly GameStateMachine _gameStateMachine;
    private readonly ISaveLoadService _saveLoadService;

    public LoadProgressState(GameStateMachine gameStateMachine,
      ISaveLoadService saveLoadService)
    {
      _gameStateMachine = gameStateMachine;
      _saveLoadService = saveLoadService;
    }

    public UniTaskVoid Enter()
    {
      _saveLoadService.LoadProgress(onLoaded: MoveToNextState);
      return default;
    }

    public UniTaskVoid Exit()
    {
      return default;
    }

    private void MoveToNextState()
    {
      _gameStateMachine.Enter<WarmUpState>();
    }
  }
}
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

    public async UniTaskVoid Enter()
    {
      _saveLoadService.LoadProgress(onLoaded: MoveToNextState);
    }

    public async UniTaskVoid Exit()
    {
    }

    private void MoveToNextState()
    {
      _gameStateMachine.Enter<WarmUpState>();
    }
  }
}
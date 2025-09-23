using Code.Infrastructure.States.Interfaces;
using Code.Services.Factories;

namespace Code.Infrastructure.States
{
  public class GameStateMachine
  {
    private readonly GameStateFactory _gameStateFactory;

    private IExitableState _currentState;

    public GameStateMachine(GameStateFactory gameStateFactory) =>
      _gameStateFactory = gameStateFactory;
    
    public void Enter<TState>() where TState : IState
    {
      IState state = ChangeState<TState>();
      state.Enter();
    }

    public void Enter<TState, TPayload>(TPayload payload) where TState : IPayloadState<TPayload>
    {
      IPayloadState<TPayload> state = ChangeState<TState>();
      state.Enter(payload);
    }

    private TState ChangeState<TState>() where TState : IExitableState
    {
      _currentState?.Exit();
      
      TState state = _gameStateFactory.GetState<TState>();
      _currentState = state;

      return state;
    }
  }
}
using Zenject;

namespace Code.Infrastructure.States
{
  public class GameStateFactory
  {
    private readonly DiContainer _diContainer;

    public GameStateFactory(DiContainer diContainer) => 
      _diContainer = diContainer;

    public TState Get<TState>() => 
      _diContainer.Resolve<TState>();
  }
}
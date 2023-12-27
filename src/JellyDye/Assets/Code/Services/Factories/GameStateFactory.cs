using Zenject;

namespace Code.Services.Factories
{
  public class GameStateFactory
  {
    private readonly DiContainer _diContainer;

    public GameStateFactory(DiContainer diContainer) => 
      _diContainer = diContainer;

    public TState Create<TState>() => 
      _diContainer.Resolve<TState>();
  }
}
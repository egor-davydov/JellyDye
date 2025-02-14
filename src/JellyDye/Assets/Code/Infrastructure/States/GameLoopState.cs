using Code.Infrastructure.States.Interfaces;
using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States
{
  public class GameLoopState : IState
  {
    public UniTaskVoid Enter()
    {
      return default;
    }

    public UniTaskVoid Exit()
    {
      return default;
    }
  }
}
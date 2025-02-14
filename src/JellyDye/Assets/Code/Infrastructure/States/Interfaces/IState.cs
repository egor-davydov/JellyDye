using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States.Interfaces
{
  public interface IState : IExitableState
  {
    UniTaskVoid Enter();
  }
}
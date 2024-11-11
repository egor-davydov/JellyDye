using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States.Interfaces
{
  public interface IExitableState
  {
    UniTaskVoid Exit();
  }
}
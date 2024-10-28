using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States
{
  public interface IExitableState
  {
    UniTaskVoid Exit();
  }
}
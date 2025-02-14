using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States.Interfaces
{
  public interface IPayloadState<TPayload> : IExitableState
  {
    UniTaskVoid Enter(TPayload payload);
  }
}
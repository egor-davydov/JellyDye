using Cysharp.Threading.Tasks;

namespace Code.Infrastructure.States
{
  public interface IPayloadState<TPayload> : IExitableState
  {
    UniTaskVoid Enter(TPayload levelIndex);
  }
}
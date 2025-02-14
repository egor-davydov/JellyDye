using System.Threading;
using Cysharp.Threading.Tasks;
using DG.Tweening;

namespace Code.Extensions
{
  public static class TweenCustomExtensions
  {
    public static UniTask RestartAndAwaitComplete(this Tween tween,
      TweenCancelBehaviour tweenCancelBehaviour = TweenCancelBehaviour.Kill,
      CancellationToken cancellationToken = default)
    {
      tween.Restart();
      return tween.AwaitForComplete(tweenCancelBehaviour, cancellationToken);
    }
  }
}
using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class Subscribe
	{
		public static readonly Action<Exception> NopError;

		public static readonly Action NopCompleted;

		public static UniTaskVoid SubscribeCore<TSource>(IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		public static UniTaskVoid SubscribeCore<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTaskVoid> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		public static UniTaskVoid SubscribeCore<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTaskVoid> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		public static UniTaskVoid SubscribeCore<TSource>(IUniTaskAsyncEnumerable<TSource> source, IObserver<TSource> observer, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		public static UniTaskVoid SubscribeAwaitCore<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		public static UniTaskVoid SubscribeAwaitCore<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}
	}
}

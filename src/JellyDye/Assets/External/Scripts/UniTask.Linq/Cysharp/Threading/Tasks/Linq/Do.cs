using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Do<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private sealed class _Do : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> MoveNextCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private readonly Action<TSource> onNext;

			private readonly Action<Exception> onError;

			private readonly Action onCompleted;

			private CancellationToken cancellationToken;

			private IUniTaskAsyncEnumerator<TSource> enumerator;

			private UniTask<bool>.Awaiter awaiter;

			public TSource Current
			{
				[CompilerGenerated]
				get
				{
					return default(TSource);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public _Do(IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action<Exception> onError, Action onCompleted, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private void CallTrySetExceptionAfterNotification(Exception ex)
			{
			}

			private bool TryGetResultWithNotification<T>(UniTask<T>.Awaiter awaiter, out T result)
			{
				result = default(T);
				return false;
			}

			private static void MoveNextCore(object state)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		private readonly Action<TSource> onNext;

		private readonly Action<Exception> onError;

		private readonly Action onCompleted;

		public Do(IUniTaskAsyncEnumerable<TSource> source, Action<TSource> onNext, Action<Exception> onError, Action onCompleted)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

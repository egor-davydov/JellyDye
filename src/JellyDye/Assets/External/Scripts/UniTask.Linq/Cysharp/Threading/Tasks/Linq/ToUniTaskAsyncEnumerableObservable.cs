using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class ToUniTaskAsyncEnumerableObservable<T> : IUniTaskAsyncEnumerable<T>
	{
		private class _ToUniTaskAsyncEnumerableObservable : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable, IObserver<T>
		{
			private static readonly Action<object> OnCanceledDelegate;

			private readonly IObservable<T> source;

			private CancellationToken cancellationToken;

			private bool useCachedCurrent;

			private T current;

			private bool subscribeCompleted;

			private readonly Queue<T> queuedResult;

			private Exception error;

			private IDisposable subscription;

			private CancellationTokenRegistration cancellationTokenRegistration;

			public T Current => default(T);

			public _ToUniTaskAsyncEnumerableObservable(IObservable<T> source, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}

			public void OnCompleted()
			{
			}

			public void OnError(Exception error)
			{
			}

			public void OnNext(T value)
			{
			}

			private static void OnCanceled(object state)
			{
			}
		}

		private readonly IObservable<T> source;

		public ToUniTaskAsyncEnumerableObservable(IObservable<T> source)
		{
		}

		public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

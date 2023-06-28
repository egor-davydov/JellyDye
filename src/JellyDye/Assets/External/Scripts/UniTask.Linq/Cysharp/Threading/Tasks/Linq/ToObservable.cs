using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class ToObservable<T> : IObservable<T>
	{
		internal sealed class CancellationTokenDisposable : IDisposable
		{
			private readonly CancellationTokenSource cts;

			public CancellationToken Token => default(CancellationToken);

			public void Dispose()
			{
			}
		}

		private readonly IUniTaskAsyncEnumerable<T> source;

		public ToObservable(IUniTaskAsyncEnumerable<T> source)
		{
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			return null;
		}

		private static UniTaskVoid RunAsync(IUniTaskAsyncEnumerable<T> src, IObserver<T> observer, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}
	}
}

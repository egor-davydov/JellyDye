using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class Empty<T> : IUniTaskAsyncEnumerable<T>
	{
		private class _Empty : IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
		{
			public static readonly IUniTaskAsyncEnumerator<T> Instance;

			public T Current => default(T);

			private _Empty()
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
		}

		public static readonly IUniTaskAsyncEnumerable<T> Instance;

		private Empty()
		{
		}

		public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

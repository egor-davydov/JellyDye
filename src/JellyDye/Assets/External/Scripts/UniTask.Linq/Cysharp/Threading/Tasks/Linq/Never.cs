using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class Never<T> : IUniTaskAsyncEnumerable<T>
	{
		private class _Never : IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
		{
			private CancellationToken cancellationToken;

			public T Current => default(T);

			public _Never(CancellationToken cancellationToken)
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

		private Never()
		{
		}

		public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

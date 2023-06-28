using System.Threading;
using System.Threading.Tasks;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class ToUniTaskAsyncEnumerableTask<T> : IUniTaskAsyncEnumerable<T>
	{
		private class _ToUniTaskAsyncEnumerableTask : IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
		{
			private readonly Task<T> source;

			private CancellationToken cancellationToken;

			private T current;

			private bool called;

			public T Current => default(T);

			public _ToUniTaskAsyncEnumerableTask(Task<T> source, CancellationToken cancellationToken)
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

		private readonly Task<T> source;

		public ToUniTaskAsyncEnumerableTask(Task<T> source)
		{
		}

		public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

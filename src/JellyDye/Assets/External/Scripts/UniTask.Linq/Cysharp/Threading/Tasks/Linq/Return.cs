using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class Return<TValue> : IUniTaskAsyncEnumerable<TValue>
	{
		private class _Return : IUniTaskAsyncEnumerator<TValue>, IUniTaskAsyncDisposable
		{
			private readonly TValue value;

			private CancellationToken cancellationToken;

			private bool called;

			public TValue Current => default(TValue);

			public _Return(TValue value, CancellationToken cancellationToken)
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

		private readonly TValue value;

		public Return(TValue value)
		{
		}

		public IUniTaskAsyncEnumerator<TValue> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

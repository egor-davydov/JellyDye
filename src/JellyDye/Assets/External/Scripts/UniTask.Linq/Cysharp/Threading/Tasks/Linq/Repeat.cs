using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class Repeat<TElement> : IUniTaskAsyncEnumerable<TElement>
	{
		private class _Repeat : IUniTaskAsyncEnumerator<TElement>, IUniTaskAsyncDisposable
		{
			private readonly TElement element;

			private readonly int count;

			private int remaining;

			private CancellationToken cancellationToken;

			public TElement Current => default(TElement);

			public _Repeat(TElement element, int count, CancellationToken cancellationToken)
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

		private readonly TElement element;

		private readonly int count;

		public Repeat(TElement element, int count)
		{
		}

		public IUniTaskAsyncEnumerator<TElement> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

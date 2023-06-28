using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class Range : IUniTaskAsyncEnumerable<int>
	{
		private class _Range : IUniTaskAsyncEnumerator<int>, IUniTaskAsyncDisposable
		{
			private readonly int start;

			private readonly int end;

			private int current;

			private CancellationToken cancellationToken;

			public int Current => 0;

			public _Range(int start, int end, CancellationToken cancellationToken)
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

		private readonly int start;

		private readonly int end;

		public Range(int start, int count)
		{
		}

		public IUniTaskAsyncEnumerator<int> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class EveryUpdate : IUniTaskAsyncEnumerable<AsyncUnit>
	{
		private class _EveryUpdate : MoveNextSource, IUniTaskAsyncEnumerator<AsyncUnit>, IUniTaskAsyncDisposable, IPlayerLoopItem
		{
			private readonly PlayerLoopTiming updateTiming;

			private CancellationToken cancellationToken;

			private bool disposed;

			public AsyncUnit Current => default(AsyncUnit);

			public _EveryUpdate(PlayerLoopTiming updateTiming, CancellationToken cancellationToken)
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

			public bool MoveNext()
			{
				return false;
			}
		}

		private readonly PlayerLoopTiming updateTiming;

		public EveryUpdate(PlayerLoopTiming updateTiming)
		{
		}

		public IUniTaskAsyncEnumerator<AsyncUnit> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class TimerFrame : IUniTaskAsyncEnumerable<AsyncUnit>
	{
		private class _TimerFrame : MoveNextSource, IUniTaskAsyncEnumerator<AsyncUnit>, IUniTaskAsyncDisposable, IPlayerLoopItem
		{
			private readonly int dueTimeFrameCount;

			private readonly int? periodFrameCount;

			private CancellationToken cancellationToken;

			private int initialFrame;

			private int currentFrame;

			private bool dueTimePhase;

			private bool completed;

			private bool disposed;

			public AsyncUnit Current => default(AsyncUnit);

			public _TimerFrame(int dueTimeFrameCount, int? periodFrameCount, PlayerLoopTiming updateTiming, CancellationToken cancellationToken)
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

		private readonly int dueTimeFrameCount;

		private readonly int? periodFrameCount;

		public TimerFrame(int dueTimeFrameCount, int? periodFrameCount, PlayerLoopTiming updateTiming)
		{
		}

		public IUniTaskAsyncEnumerator<AsyncUnit> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

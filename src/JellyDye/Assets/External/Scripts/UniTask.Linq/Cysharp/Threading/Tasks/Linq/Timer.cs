using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class Timer : IUniTaskAsyncEnumerable<AsyncUnit>
	{
		private class _Timer : MoveNextSource, IUniTaskAsyncEnumerator<AsyncUnit>, IUniTaskAsyncDisposable, IPlayerLoopItem
		{
			private readonly float dueTime;

			private readonly float? period;

			private readonly PlayerLoopTiming updateTiming;

			private readonly bool ignoreTimeScale;

			private CancellationToken cancellationToken;

			private int initialFrame;

			private float elapsed;

			private bool dueTimePhase;

			private bool completed;

			private bool disposed;

			public AsyncUnit Current => default(AsyncUnit);

			public _Timer(TimeSpan dueTime, TimeSpan? period, PlayerLoopTiming updateTiming, bool ignoreTimeScale, CancellationToken cancellationToken)
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

		private readonly TimeSpan dueTime;

		private readonly TimeSpan? period;

		private readonly bool ignoreTimeScale;

		public Timer(TimeSpan dueTime, TimeSpan? period, PlayerLoopTiming updateTiming, bool ignoreTimeScale)
		{
		}

		public IUniTaskAsyncEnumerator<AsyncUnit> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

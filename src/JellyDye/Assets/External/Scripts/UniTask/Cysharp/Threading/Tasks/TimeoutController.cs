using System;
using System.Threading;
using Cysharp.Threading.Tasks.Internal;

namespace Cysharp.Threading.Tasks
{
	public sealed class TimeoutController : IDisposable
	{
		private enum DelayResult
		{
			LinkedTokenCanceled = 0,
			ExternalStopped = 1,
			DelayCompleted = 2
		}

		private sealed class StoppableDelayRealtimePromise : IUniTaskSource<DelayResult>, IUniTaskSource, IPlayerLoopItem, ITaskPoolNode<StoppableDelayRealtimePromise>
		{
			private static OperationCanceledException ExterenalStopException;

			private static TaskPool<StoppableDelayRealtimePromise> pool;

			private StoppableDelayRealtimePromise nextNode;

			private long delayTimeSpanTicks;

			private ValueStopwatch stopwatch;

			private CancellationToken cancellationToken;

			private bool externalStop;

			private UniTaskCompletionSourceCore<DelayResult> core;

			public unsafe ref StoppableDelayRealtimePromise NextNode => ref *(StoppableDelayRealtimePromise*)null;

			static StoppableDelayRealtimePromise()
			{
			}

			private StoppableDelayRealtimePromise()
			{
			}

			public static StoppableDelayRealtimePromise Create(TimeSpan delayTimeSpan, PlayerLoopTiming timing, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			public void Stop()
			{
			}

			public void RestartStopwatch()
			{
			}

			public DelayResult GetResult(short token)
			{
				return default(DelayResult);
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}

			public UniTaskStatus GetStatus(short token)
			{
				return default(UniTaskStatus);
			}

			public UniTaskStatus UnsafeGetStatus()
			{
				return default(UniTaskStatus);
			}

			public void OnCompleted(Action<object> continuation, object state, short token)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			private bool TryReturn()
			{
				return false;
			}
		}

		private CancellationTokenSource timeoutSource;

		private CancellationTokenSource linkedSource;

		private StoppableDelayRealtimePromise timeoutDelay;

		private readonly CancellationTokenSource originalLinkCancellationTokenSource;

		public TimeoutController()
		{
		}

		public TimeoutController(CancellationTokenSource linkCancellationTokenSource)
		{
		}

		public CancellationToken Timeout(TimeSpan timeout)
		{
			return default(CancellationToken);
		}

		public bool IsTimeout()
		{
			return false;
		}

		public void Reset()
		{
		}

		private UniTaskVoid RunDelayAsync(TimeSpan timeout)
		{
			return default(UniTaskVoid);
		}

		public void Dispose()
		{
		}
	}
}

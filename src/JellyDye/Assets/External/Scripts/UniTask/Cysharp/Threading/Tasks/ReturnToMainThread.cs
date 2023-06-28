using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public struct ReturnToMainThread
	{
		public readonly struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly PlayerLoopTiming timing;

			private readonly CancellationToken cancellationToken;

			public bool IsCompleted => false;

			public Awaiter(PlayerLoopTiming timing, CancellationToken cancellationToken)
			{
			}

			public Awaiter GetAwaiter()
			{
				return default(Awaiter);
			}

			public void GetResult()
			{
			}

			public void OnCompleted(Action continuation)
			{
			}

			public void UnsafeOnCompleted(Action continuation)
			{
			}
		}

		private readonly PlayerLoopTiming playerLoopTiming;

		private readonly CancellationToken cancellationToken;

		public ReturnToMainThread(PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken)
		{
		}

		public Awaiter DisposeAsync()
		{
			return default(Awaiter);
		}
	}
}

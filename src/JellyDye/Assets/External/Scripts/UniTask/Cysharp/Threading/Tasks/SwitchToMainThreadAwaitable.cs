using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public struct SwitchToMainThreadAwaitable
	{
		public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly PlayerLoopTiming playerLoopTiming;

			private readonly CancellationToken cancellationToken;

			public bool IsCompleted => false;

			public Awaiter(PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken)
			{
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

		public SwitchToMainThreadAwaitable(PlayerLoopTiming playerLoopTiming, CancellationToken cancellationToken)
		{
		}

		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}
	}
}

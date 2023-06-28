using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public struct SwitchToSynchronizationContextAwaitable
	{
		public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private static readonly SendOrPostCallback switchToCallback;

			private readonly SynchronizationContext synchronizationContext;

			private readonly CancellationToken cancellationToken;

			public bool IsCompleted => false;

			public Awaiter(SynchronizationContext synchronizationContext, CancellationToken cancellationToken)
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

			private static void Callback(object state)
			{
			}
		}

		private readonly SynchronizationContext synchronizationContext;

		private readonly CancellationToken cancellationToken;

		public SwitchToSynchronizationContextAwaitable(SynchronizationContext synchronizationContext, CancellationToken cancellationToken)
		{
		}

		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public struct ReturnToSynchronizationContext
	{
		public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private static readonly SendOrPostCallback switchToCallback;

			private readonly SynchronizationContext synchronizationContext;

			private readonly bool dontPostWhenSameContext;

			private readonly CancellationToken cancellationToken;

			public bool IsCompleted => false;

			public Awaiter(SynchronizationContext synchronizationContext, bool dontPostWhenSameContext, CancellationToken cancellationToken)
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

			private static void Callback(object state)
			{
			}
		}

		private readonly SynchronizationContext syncContext;

		private readonly bool dontPostWhenSameContext;

		private readonly CancellationToken cancellationToken;

		public ReturnToSynchronizationContext(SynchronizationContext syncContext, bool dontPostWhenSameContext, CancellationToken cancellationToken)
		{
		}

		public Awaiter DisposeAsync()
		{
			return default(Awaiter);
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	[StructLayout(0, Size = 1)]
	public struct SwitchToThreadPoolAwaitable
	{
		[StructLayout(0, Size = 1)]
		public struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private static readonly WaitCallback switchToCallback;

			public bool IsCompleted => false;

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

		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}
	}
}

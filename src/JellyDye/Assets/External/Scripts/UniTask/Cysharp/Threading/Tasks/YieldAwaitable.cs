using System;
using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks
{
	public readonly struct YieldAwaitable
	{
		public readonly struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly PlayerLoopTiming timing;

			public bool IsCompleted => false;

			public Awaiter(PlayerLoopTiming timing)
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

		private readonly PlayerLoopTiming timing;

		public YieldAwaitable(PlayerLoopTiming timing)
		{
		}

		public Awaiter GetAwaiter()
		{
			return default(Awaiter);
		}

		public UniTask ToUniTask()
		{
			return default(UniTask);
		}
	}
}

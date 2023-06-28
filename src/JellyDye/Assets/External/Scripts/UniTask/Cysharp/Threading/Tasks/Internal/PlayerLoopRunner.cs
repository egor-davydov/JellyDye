using System;
using System.Diagnostics;

namespace Cysharp.Threading.Tasks.Internal
{
	internal sealed class PlayerLoopRunner
	{
		private const int InitialSize = 16;

		private readonly PlayerLoopTiming timing;

		private readonly object runningAndQueueLock;

		private readonly object arrayLock;

		private readonly Action<Exception> unhandledExceptionCallback;

		private int tail;

		private bool running;

		private IPlayerLoopItem[] loopItems;

		private MinimumQueue<IPlayerLoopItem> waitQueue;

		public PlayerLoopRunner(PlayerLoopTiming timing)
		{
		}

		public void AddAction(IPlayerLoopItem item)
		{
		}

		public int Clear()
		{
			return 0;
		}

		public void Run()
		{
		}

		private void Initialization()
		{
		}

		private void LastInitialization()
		{
		}

		private void EarlyUpdate()
		{
		}

		private void LastEarlyUpdate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LastFixedUpdate()
		{
		}

		private void PreUpdate()
		{
		}

		private void LastPreUpdate()
		{
		}

		private void Update()
		{
		}

		private void LastUpdate()
		{
		}

		private void PreLateUpdate()
		{
		}

		private void LastPreLateUpdate()
		{
		}

		private void PostLateUpdate()
		{
		}

		private void LastPostLateUpdate()
		{
		}

		private void TimeUpdate()
		{
		}

		private void LastTimeUpdate()
		{
		}

		[DebuggerHidden]
		private void RunCore()
		{
		}
	}
}

using System;
using System.Diagnostics;
using System.Threading;

namespace Cysharp.Threading.Tasks.Internal
{
	internal sealed class ContinuationQueue
	{
		private const int MaxArrayLength = 2146435071;

		private const int InitialSize = 16;

		private readonly PlayerLoopTiming timing;

		private SpinLock gate;

		private bool dequing;

		private int actionListCount;

		private Action[] actionList;

		private int waitingListCount;

		private Action[] waitingList;

		public ContinuationQueue(PlayerLoopTiming timing)
		{
		}

		public void Enqueue(Action continuation)
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

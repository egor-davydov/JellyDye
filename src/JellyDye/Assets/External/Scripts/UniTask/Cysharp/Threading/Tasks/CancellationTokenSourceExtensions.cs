using System;
using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks
{
	public static class CancellationTokenSourceExtensions
	{
		public static void CancelAfterSlim(this CancellationTokenSource cts, int millisecondsDelay, DelayType delayType = DelayType.DeltaTime, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update)
		{
		}

		public static void CancelAfterSlim(this CancellationTokenSource cts, TimeSpan delayTimeSpan, DelayType delayType = DelayType.DeltaTime, PlayerLoopTiming delayTiming = PlayerLoopTiming.Update)
		{
		}

		private static UniTaskVoid CancelAfterCore(CancellationTokenSource cts, UniTask delayTask)
		{
			return default(UniTaskVoid);
		}

		public static void RegisterRaiseCancelOnDestroy(this CancellationTokenSource cts, Component component)
		{
		}

		public static void RegisterRaiseCancelOnDestroy(this CancellationTokenSource cts, GameObject gameObject)
		{
		}
	}
}

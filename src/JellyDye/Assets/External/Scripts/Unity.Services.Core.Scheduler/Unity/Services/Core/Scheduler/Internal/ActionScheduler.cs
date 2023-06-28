using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.Services.Core.Internal;
using UnityEngine.LowLevel;

namespace Unity.Services.Core.Scheduler.Internal
{
	internal class ActionScheduler : IActionScheduler, IServiceComponent
	{
		private readonly ITimeProvider m_TimeProvider;

		private readonly MinimumBinaryHeap<ScheduledInvocation> m_ScheduledActions;

		private readonly Dictionary<long, ScheduledInvocation> m_IdScheduledInvocationMap;

		internal readonly PlayerLoopSystem SchedulerLoopSystem;

		private long m_NextId;

		public ActionScheduler()
		{
		}

		public ActionScheduler(ITimeProvider timeProvider)
		{
		}

		public long ScheduleAction([NotNull] Action action, double delaySeconds = 0.0)
		{
			return 0L;
		}

		public void CancelAction(long actionId)
		{
		}

		internal void ExecuteExpiredActions()
		{
		}

		private static void UpdateSubSystemList(List<PlayerLoopSystem> subSystemList, PlayerLoopSystem currentPlayerLoop)
		{
		}

		public void JoinPlayerLoopSystem()
		{
		}
	}
}

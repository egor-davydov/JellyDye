using System;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Scheduler.Internal
{
	public interface IActionScheduler : IServiceComponent
	{
		long ScheduleAction(Action action, double delaySeconds = 0.0);

		void CancelAction(long actionId);
	}
}

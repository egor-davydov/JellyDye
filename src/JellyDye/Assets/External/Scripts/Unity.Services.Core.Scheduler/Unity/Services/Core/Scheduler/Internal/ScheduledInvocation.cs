using System;

namespace Unity.Services.Core.Scheduler.Internal
{
	internal class ScheduledInvocation : IComparable<ScheduledInvocation>
	{
		public Action Action;

		public DateTime InvocationTime;

		public long ActionId;

		public int CompareTo(ScheduledInvocation that)
		{
			return 0;
		}
	}
}

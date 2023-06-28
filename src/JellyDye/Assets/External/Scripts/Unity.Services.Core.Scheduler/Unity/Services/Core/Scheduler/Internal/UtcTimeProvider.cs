using System;

namespace Unity.Services.Core.Scheduler.Internal
{
	internal class UtcTimeProvider : ITimeProvider
	{
		public DateTime Now => default(DateTime);
	}
}

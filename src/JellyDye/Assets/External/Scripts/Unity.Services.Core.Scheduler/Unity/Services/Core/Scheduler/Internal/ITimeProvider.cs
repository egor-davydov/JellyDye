using System;

namespace Unity.Services.Core.Scheduler.Internal
{
	internal interface ITimeProvider
	{
		DateTime Now { get; }
	}
}

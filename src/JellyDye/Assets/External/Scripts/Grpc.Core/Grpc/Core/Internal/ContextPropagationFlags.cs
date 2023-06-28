using System;

namespace Grpc.Core.Internal
{
	[Flags]
	internal enum ContextPropagationFlags
	{
		Deadline = 1,
		CensusStatsContext = 2,
		CensusTracingContext = 4,
		Cancellation = 8
	}
}

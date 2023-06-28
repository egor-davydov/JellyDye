using System;

namespace Unity.Services.Core.Telemetry.Internal
{
	[Serializable]
	internal class CachedPayload<TPayload> where TPayload : ITelemetryPayload
	{
		public long TimeOfOccurenceTicks;

		public TPayload Payload;
	}
}

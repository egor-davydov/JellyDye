namespace Unity.Services.Core.Telemetry.Internal
{
	internal static class CacheExtensions
	{
		public static bool IsEmpty<TPayload>(this CachedPayload<TPayload> self) where TPayload : ITelemetryPayload
		{
			return false;
		}

		public static void AddRangeFrom(this CachedPayload<DiagnosticsPayload> self, CachedPayload<DiagnosticsPayload> payload)
		{
		}

		public static void Add<TPayload>(this CachedPayload<TPayload> self, ITelemetryEvent telemetryEvent) where TPayload : ITelemetryPayload
		{
		}
	}
}

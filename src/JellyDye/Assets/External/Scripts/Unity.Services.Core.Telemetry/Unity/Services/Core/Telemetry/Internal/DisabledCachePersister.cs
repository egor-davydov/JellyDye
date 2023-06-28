namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DisabledCachePersister<TPayload> : ICachePersister<TPayload> where TPayload : ITelemetryPayload
	{
		public bool CanPersist => false;

		public void Persist(CachedPayload<TPayload> cache)
		{
		}

		public bool TryFetch(out CachedPayload<TPayload> persistedCache)
		{
			persistedCache = null;
			return false;
		}

		public void Delete()
		{
		}
	}
}

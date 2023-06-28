using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Scheduler.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class MetricsHandler : TelemetryHandler<MetricsPayload, Metric>
	{
		public MetricsHandler(TelemetryConfig config, CachedPayload<MetricsPayload> cache, IActionScheduler scheduler, ICachePersister<MetricsPayload> cachePersister, TelemetrySender sender)
		{
			((TelemetryHandler<, >)(object)this)._002Ector((TelemetryConfig)null, (CachedPayload<TPayload>)null, (IActionScheduler)null, (ICachePersister<TPayload>)null, (TelemetrySender)null);
		}

		internal override void SendPersistedCache(CachedPayload<MetricsPayload> persistedCache)
		{
		}

		internal override void FetchSpecificCommonTags(ICloudProjectId cloudProjectId, IEnvironments environments)
		{
		}

		internal override void SendCachedPayload()
		{
		}
	}
}

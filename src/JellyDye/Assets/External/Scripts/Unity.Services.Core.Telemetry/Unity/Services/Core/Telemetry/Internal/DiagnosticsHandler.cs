using System.Threading.Tasks;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Scheduler.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DiagnosticsHandler : TelemetryHandler<DiagnosticsPayload, Diagnostic>
	{
		private class SendState
		{
			public DiagnosticsHandler Self;

			public CachedPayload<DiagnosticsPayload> Payload;
		}

		public DiagnosticsHandler(TelemetryConfig config, CachedPayload<DiagnosticsPayload> cache, IActionScheduler scheduler, ICachePersister<DiagnosticsPayload> cachePersister, TelemetrySender sender)
		{
			((TelemetryHandler<, >)(object)this)._002Ector((TelemetryConfig)null, (CachedPayload<TPayload>)null, (IActionScheduler)null, (ICachePersister<TPayload>)null, (TelemetrySender)null);
		}

		internal override void SendPersistedCache(CachedPayload<DiagnosticsPayload> persistedCache)
		{
		}

		private static void OnSendAsyncCompleted(Task sendOperation, object state)
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

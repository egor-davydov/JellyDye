using System.Runtime.CompilerServices;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Scheduler.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal abstract class TelemetryHandler
	{
		internal static string FormatOperatingSystemInfo(string rawOsInfo)
		{
			return null;
		}
	}
	internal abstract class TelemetryHandler<TPayload, TEvent> : TelemetryHandler where TPayload : ITelemetryPayload where TEvent : ITelemetryEvent
	{
		private readonly IActionScheduler m_Scheduler;

		protected readonly ICachePersister<TPayload> m_CachePersister;

		protected readonly TelemetrySender m_Sender;

		internal long SendingLoopScheduleId;

		internal long PersistenceLoopScheduleId;

		public TelemetryConfig Config
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public CachedPayload<TPayload> Cache
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		protected TelemetryHandler(TelemetryConfig config, CachedPayload<TPayload> cache, IActionScheduler scheduler, ICachePersister<TPayload> cachePersister, TelemetrySender sender)
		{
		}

		public void Initialize(ICloudProjectId cloudProjectId, IEnvironments environments)
		{
		}

		internal void HandlePersistedCache()
		{
		}

		internal abstract void SendPersistedCache(CachedPayload<TPayload> persistedCache);

		private void FetchAllCommonTags(ICloudProjectId cloudProjectId, IEnvironments environments)
		{
		}

		internal abstract void FetchSpecificCommonTags(ICloudProjectId cloudProjectId, IEnvironments environments);

		internal void FetchTelemetryCommonTags()
		{
		}

		internal void ScheduleSendingLoop()
		{
		}

		internal abstract void SendCachedPayload();

		internal void SchedulePersistenceLoop()
		{
		}

		internal void PersistCache()
		{
		}

		public void Register(TEvent telemetryEvent)
		{
		}
	}
}

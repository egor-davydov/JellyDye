using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Scheduler.Internal;
using UnityEngine;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal static class TelemetryUtils
	{
		public static IMetricsFactory CreateMetricsFactory(IActionScheduler scheduler, IProjectConfiguration projectConfiguration, ICloudProjectId cloudProjectId, IEnvironments environments)
		{
			return null;
		}

		public static IDiagnosticsFactory CreateDiagnosticsFactory(IActionScheduler scheduler, IProjectConfiguration projectConfiguration, ICloudProjectId cloudProjectId, IEnvironments environments)
		{
			return null;
		}

		private static bool IsTelemetryDisabled(IProjectConfiguration projectConfiguration)
		{
			return false;
		}

		internal static ICachePersister<TPayload> CreateCachePersister<TPayload>(string fileName, RuntimePlatform platform) where TPayload : ITelemetryPayload
		{
			return null;
		}

		internal static TelemetryConfig CreateTelemetryConfig(IProjectConfiguration projectConfiguration)
		{
			return null;
		}
	}
}

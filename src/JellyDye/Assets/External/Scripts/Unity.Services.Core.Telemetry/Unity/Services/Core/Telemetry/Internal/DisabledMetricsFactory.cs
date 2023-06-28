using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DisabledMetricsFactory : IMetricsFactory, IServiceComponent
	{
		private IMetrics Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EIMetricsFactory_002ECreate(string packageName)
		{
			return null;
		}
	}
}

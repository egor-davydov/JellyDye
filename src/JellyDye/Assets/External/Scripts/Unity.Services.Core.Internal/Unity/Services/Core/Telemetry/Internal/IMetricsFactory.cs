using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	public interface IMetricsFactory : IServiceComponent
	{
		IMetrics Create(string packageName);
	}
}

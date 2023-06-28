using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DisabledMetrics : IMetrics
	{
		private void Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EIMetrics_002ESendGaugeMetric(string name, double value, IDictionary<string, string> tags)
		{
		}

		private void Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EIMetrics_002ESendHistogramMetric(string name, double time, IDictionary<string, string> tags)
		{
		}

		private void Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EIMetrics_002ESendSumMetric(string name, double value, IDictionary<string, string> tags)
		{
		}
	}
}

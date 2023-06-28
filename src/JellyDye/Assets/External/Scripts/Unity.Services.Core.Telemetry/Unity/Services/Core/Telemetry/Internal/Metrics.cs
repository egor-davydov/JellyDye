using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class Metrics : IMetrics
	{
		internal MetricsHandler Handler
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal IDictionary<string, string> PackageTags
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Metrics(MetricsHandler handler, IDictionary<string, string> packageTags)
		{
		}

		internal Metric CreateMetric(string name, double value, MetricType type, IDictionary<string, string> tags)
		{
			return default(Metric);
		}

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

using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	public interface IMetrics
	{
		void SendGaugeMetric(string name, double value = 0.0, IDictionary<string, string> tags = null);

		void SendHistogramMetric(string name, double time, IDictionary<string, string> tags = null);

		void SendSumMetric(string name, double value = 1.0, IDictionary<string, string> tags = null);
	}
}

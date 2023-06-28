using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	[Serializable]
	internal struct MetricsPayload : ITelemetryPayload
	{
		public List<Metric> Metrics;

		public Dictionary<string, string> CommonTags;

		public Dictionary<string, string> MetricsCommonTags;

		private Dictionary<string, string> Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EITelemetryPayload_002ECommonTags => null;

		private int Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EITelemetryPayload_002ECount => 0;

		private void Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EITelemetryPayload_002EAdd(ITelemetryEvent telemetryEvent)
		{
		}
	}
}

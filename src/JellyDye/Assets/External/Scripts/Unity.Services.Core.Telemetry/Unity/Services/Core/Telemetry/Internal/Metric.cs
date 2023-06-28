using System;
using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	[Serializable]
	internal struct Metric : ITelemetryEvent
	{
		public string Name;

		public double Value;

		public MetricType Type;

		public IDictionary<string, string> Tags;
	}
}

using System.Runtime.Serialization;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal enum MetricType
	{
		[EnumMember]
		Gauge = 0,
		[EnumMember]
		Sum = 1,
		[EnumMember]
		Histogram = 2
	}
}

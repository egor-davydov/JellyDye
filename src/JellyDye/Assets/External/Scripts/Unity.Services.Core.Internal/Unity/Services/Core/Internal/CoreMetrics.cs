using System.Runtime.CompilerServices;
using Unity.Services.Core.Telemetry.Internal;

namespace Unity.Services.Core.Internal
{
	internal class CoreMetrics
	{
		public static CoreMetrics Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		internal IMetrics Metrics
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SendAllPackagesInitSuccessMetric()
		{
		}

		public void SendAllPackagesInitTimeMetric(double initTimeSeconds)
		{
		}

		public void SendCorePackageInitTimeMetric(double initTimeSeconds)
		{
		}
	}
}

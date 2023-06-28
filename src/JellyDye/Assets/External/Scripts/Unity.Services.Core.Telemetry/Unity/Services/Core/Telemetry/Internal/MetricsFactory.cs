using System.Runtime.CompilerServices;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class MetricsFactory : IMetricsFactory, IServiceComponent
	{
		private readonly IProjectConfiguration m_ProjectConfig;

		internal MetricsHandler Handler
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public MetricsFactory(MetricsHandler handler, IProjectConfiguration projectConfig)
		{
		}

		public IMetrics Create(string packageName)
		{
			return null;
		}
	}
}

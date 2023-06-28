using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Unity.Services.Core.Configuration;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device;
using Unity.Services.Core.Environments.Internal;
using Unity.Services.Core.Internal;
using Unity.Services.Core.Scheduler.Internal;
using Unity.Services.Core.Telemetry.Internal;
using Unity.Services.Core.Threading.Internal;
using UnityEngine;

namespace Unity.Services.Core.Registration
{
	internal class CorePackageInitializer : IInitializablePackage, Unity.Services.Core.Telemetry.Internal.IDiagnosticsComponentProvider
	{
		private InitializationOptions m_CurrentInitializationOptions;

		internal Unity.Services.Core.Scheduler.Internal.ActionScheduler ActionScheduler
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal Unity.Services.Core.Device.InstallationId InstallationId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal Unity.Services.Core.Configuration.ProjectConfiguration ProjectConfig
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal Unity.Services.Core.Environments.Internal.Environments Environments
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal Unity.Services.Core.Configuration.CloudProjectId CloudProjectId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal IDiagnosticsFactory DiagnosticsFactory
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal IMetricsFactory MetricsFactory
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal Unity.Services.Core.Threading.Internal.UnityThreadUtilsInternal UnityThreadUtils
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		[RuntimeInitializeOnLoadMethod]
		private static void Register()
		{
		}

		public Task Initialize(CoreRegistry registry)
		{
			return null;
		}

		private bool HaveInitOptionsChanged()
		{
			return false;
		}

		private void FreeOptionsDependantComponents()
		{
		}

		internal void InitializeInstallationId()
		{
		}

		internal void InitializeActionScheduler()
		{
		}

		internal Task InitializeProjectConfigAsync([NotNull] InitializationOptions options)
		{
			return null;
		}

		internal static Task<Unity.Services.Core.Configuration.ProjectConfiguration> GenerateProjectConfigurationAsync([NotNull] InitializationOptions options)
		{
			return null;
		}

		internal static Task<Unity.Services.Core.Configuration.SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync()
		{
			return null;
		}

		internal void InitializeEnvironments(IProjectConfiguration projectConfiguration)
		{
		}

		internal void InitializeCloudProjectId()
		{
		}

		internal void InitializeDiagnostics(IActionScheduler scheduler, IProjectConfiguration projectConfiguration, ICloudProjectId cloudProjectId, IEnvironments environments)
		{
		}

		internal void InitializeMetrics(IActionScheduler scheduler, IProjectConfiguration projectConfiguration, ICloudProjectId cloudProjectId, IEnvironments environments)
		{
		}

		internal void InitializeUnityThreadUtils()
		{
		}

		public Task<IDiagnosticsFactory> CreateDiagnosticsComponents()
		{
			return null;
		}

		public Task<string> GetSerializedProjectConfigurationAsync()
		{
			return null;
		}
	}
}

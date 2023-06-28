using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Unity.Services.Core.Internal
{
	internal class UnityServicesInternal : Unity.Services.Core.IUnityServices
	{
		internal bool CanInitialize;

		private TaskCompletionSource<object> m_Initialization;

		public ServicesInitializationState State
		{
			[CompilerGenerated]
			get
			{
				return default(ServicesInitializationState);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public InitializationOptions Options
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

		[NotNull]
		private CoreRegistry Registry
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[NotNull]
		private CoreMetrics Metrics
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[NotNull]
		private CoreDiagnostics Diagnostics
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public UnityServicesInternal([NotNull] CoreRegistry registry, [NotNull] CoreMetrics metrics, [NotNull] CoreDiagnostics diagnostics)
		{
		}

		public Task InitializeAsync(InitializationOptions options)
		{
			return null;
		}

		private bool HasRequestedInitialization()
		{
			return false;
		}

		private Task InitializeServicesAsync()
		{
			return null;
		}

		internal Task EnableInitializationAsync()
		{
			return null;
		}
	}
}

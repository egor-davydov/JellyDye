using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Unity.Services.Core.Telemetry.Internal;

namespace Unity.Services.Core.Internal
{
	internal class CoreDiagnostics
	{
		public IDictionary<string, string> CoreTags
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

		public static CoreDiagnostics Instance
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

		internal IDiagnosticsComponentProvider DiagnosticsComponentProvider
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

		internal IDiagnostics Diagnostics
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

		private Task<IDiagnostics> GetOrCreateDiagnostics()
		{
			return null;
		}

		public void SetProjectConfiguration(string serializedProjectConfig)
		{
		}

		public void SendCircularDependencyDiagnostics(Exception exception)
		{
		}

		public void SendCorePackageInitDiagnostics(Exception exception)
		{
		}

		public void SendOperateServicesInitDiagnostics(Exception exception)
		{
		}

		private static void OnSendFailed(Task failedSendTask)
		{
		}

		private Task SendCoreDiagnostics(string diagnosticName, Exception exception)
		{
			return null;
		}
	}
}

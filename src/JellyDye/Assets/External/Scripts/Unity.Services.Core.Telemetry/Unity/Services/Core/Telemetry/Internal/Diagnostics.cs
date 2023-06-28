using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class Diagnostics : IDiagnostics
	{
		internal DiagnosticsHandler Handler
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

		public Diagnostics(DiagnosticsHandler handler, IDictionary<string, string> packageTags)
		{
		}

		public void SendDiagnostic(string name, string message, IDictionary<string, string> tags = null)
		{
		}
	}
}

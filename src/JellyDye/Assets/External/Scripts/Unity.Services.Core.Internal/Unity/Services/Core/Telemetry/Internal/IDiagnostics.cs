using System.Collections.Generic;

namespace Unity.Services.Core.Telemetry.Internal
{
	public interface IDiagnostics
	{
		void SendDiagnostic(string name, string message, IDictionary<string, string> tags = null);
	}
}

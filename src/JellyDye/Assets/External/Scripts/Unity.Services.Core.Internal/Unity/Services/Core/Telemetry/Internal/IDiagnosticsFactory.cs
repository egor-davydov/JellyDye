using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	public interface IDiagnosticsFactory : IServiceComponent
	{
		IDiagnostics Create(string packageName);
	}
}

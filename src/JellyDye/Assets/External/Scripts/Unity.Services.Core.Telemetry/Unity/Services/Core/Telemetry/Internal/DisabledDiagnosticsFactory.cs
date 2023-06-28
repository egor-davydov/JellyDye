using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class DisabledDiagnosticsFactory : IDiagnosticsFactory, IServiceComponent
	{
		private IDiagnostics Unity_002EServices_002ECore_002ETelemetry_002EInternal_002EIDiagnosticsFactory_002ECreate(string packageName)
		{
			return null;
		}
	}
}

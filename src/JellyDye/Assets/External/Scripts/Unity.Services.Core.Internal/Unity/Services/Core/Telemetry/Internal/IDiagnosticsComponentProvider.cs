using System.Threading.Tasks;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal interface IDiagnosticsComponentProvider
	{
		Task<IDiagnosticsFactory> CreateDiagnosticsComponents();

		Task<string> GetSerializedProjectConfigurationAsync();
	}
}

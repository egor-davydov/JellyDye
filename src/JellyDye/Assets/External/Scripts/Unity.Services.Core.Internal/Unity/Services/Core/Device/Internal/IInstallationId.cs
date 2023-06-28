using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Device.Internal
{
	public interface IInstallationId : IServiceComponent
	{
		string GetOrCreateIdentifier();
	}
}

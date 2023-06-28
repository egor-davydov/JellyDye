using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Configuration.Internal
{
	public interface ICloudProjectId : IServiceComponent
	{
		string GetCloudProjectId();
	}
}

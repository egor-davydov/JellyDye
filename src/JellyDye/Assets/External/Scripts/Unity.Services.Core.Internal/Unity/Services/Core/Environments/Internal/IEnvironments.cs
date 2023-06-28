using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Environments.Internal
{
	public interface IEnvironments : IServiceComponent
	{
		string Current { get; }
	}
}

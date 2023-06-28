using System.Threading.Tasks;

namespace Unity.Services.Core.Configuration
{
	internal interface IConfigurationLoader
	{
		Task<SerializableProjectConfiguration> GetConfigAsync();
	}
}

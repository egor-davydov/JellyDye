using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Configuration.Internal
{
	public interface IProjectConfiguration : IServiceComponent
	{
		bool GetBool(string key, bool defaultValue = false);

		int GetInt(string key, int defaultValue = 0);

		string GetString(string key, string defaultValue = null);
	}
}

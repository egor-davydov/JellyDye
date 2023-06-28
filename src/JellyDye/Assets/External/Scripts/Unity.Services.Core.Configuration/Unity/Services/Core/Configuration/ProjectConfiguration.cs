using System.Collections.Generic;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Configuration
{
	internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent
	{
		private string m_JsonCache;

		private readonly IReadOnlyDictionary<string, ConfigurationEntry> m_ConfigValues;

		public ProjectConfiguration(IReadOnlyDictionary<string, ConfigurationEntry> configValues)
		{
		}

		public bool GetBool(string key, bool defaultValue = false)
		{
			return false;
		}

		public int GetInt(string key, int defaultValue = 0)
		{
			return 0;
		}

		public string GetString(string key, string defaultValue = null)
		{
			return null;
		}

		public string ToJson()
		{
			return null;
		}
	}
}

using System.Collections.Generic;

namespace Unity.Services.Core.Configuration
{
	internal static class ConfigurationCollectionHelper
	{
		public static void FillWith(this IDictionary<string, ConfigurationEntry> self, SerializableProjectConfiguration config)
		{
		}

		public static void FillWith(this IDictionary<string, ConfigurationEntry> self, InitializationOptions options)
		{
		}

		private static void SetOrCreateEntry(this IDictionary<string, ConfigurationEntry> self, string key, ConfigurationEntry entry)
		{
		}
	}
}

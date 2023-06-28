namespace Newtonsoft.Json.Serialization
{
	public class SnakeCaseNamingStrategy : NamingStrategy
	{
		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
		}

		public SnakeCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
		{
		}

		public SnakeCaseNamingStrategy()
		{
		}

		protected override string ResolvePropertyName(string name)
		{
			return null;
		}
	}
}

namespace Newtonsoft.Json.Serialization
{
	public class CamelCaseNamingStrategy : NamingStrategy
	{
		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames)
		{
		}

		public CamelCaseNamingStrategy(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames)
		{
		}

		public CamelCaseNamingStrategy()
		{
		}

		protected override string ResolvePropertyName(string name)
		{
			return null;
		}
	}
}

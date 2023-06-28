using Unity.Services.Core.Device.Internal;
using Unity.Services.Core.Internal;

namespace Unity.Services.Core.Device
{
	internal class InstallationId : IInstallationId, IServiceComponent
	{
		internal string Identifier;

		internal IUserIdentifierProvider UnityAdsIdentifierProvider;

		internal IUserIdentifierProvider UnityAnalyticsIdentifierProvider;

		public string GetOrCreateIdentifier()
		{
			return null;
		}

		public void CreateIdentifier()
		{
		}

		private static string ReadIdentifierFromFile()
		{
			return null;
		}

		private static void WriteIdentifierToFile(string identifier)
		{
		}

		private static string GenerateGuid()
		{
			return null;
		}
	}
}

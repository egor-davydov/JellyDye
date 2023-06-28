using System.Runtime.CompilerServices;
using Unity.Services.Core.Device.Internal;

namespace Unity.Services.Analytics
{
	internal class InternalNewPlayerHelper
	{
		internal IInstallationId InstallId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal InternalNewPlayerHelper(IInstallationId installId)
		{
		}

		internal bool IsNewPlayer()
		{
			return false;
		}

		internal string ReadAnalyticsIdentifier()
		{
			return null;
		}

		internal void WriteAnalyticsIdentifierToFile(string identifier)
		{
		}
	}
}

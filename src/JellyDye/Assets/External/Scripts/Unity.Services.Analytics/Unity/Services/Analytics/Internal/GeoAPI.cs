using System.Threading.Tasks;

namespace Unity.Services.Analytics.Internal
{
	internal class GeoAPI : IGeoAPI
	{
		private readonly string m_PrivacyEndpoint;

		public Task<GeoIPResponse> MakeRequest()
		{
			return null;
		}
	}
}

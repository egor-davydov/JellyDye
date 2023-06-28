using System.Threading.Tasks;

namespace Unity.Services.Analytics.Internal
{
	internal interface IGeoAPI
	{
		Task<GeoIPResponse> MakeRequest();
	}
}

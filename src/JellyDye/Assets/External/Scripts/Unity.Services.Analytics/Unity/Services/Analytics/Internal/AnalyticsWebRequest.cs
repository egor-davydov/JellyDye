using System.Runtime.CompilerServices;
using UnityEngine.Networking;

namespace Unity.Services.Analytics.Internal
{
	internal class AnalyticsWebRequest : UnityWebRequest, IWebRequest
	{
		internal AnalyticsWebRequest(string url, string method)
			: base(null, null)
		{
		}

		private UnityWebRequestAsyncOperation Unity_002EServices_002EAnalytics_002EInternal_002EIWebRequest_002ESendWebRequest()
		{
			return null;
		}

		private void Unity_002EServices_002EAnalytics_002EInternal_002EIWebRequest_002ESetRequestHeader(string key, string value)
		{
		}

		[SpecialName]
		private bool Unity_002EServices_002EAnalytics_002EInternal_002EIWebRequest_002Eget_isNetworkError()
		{
			return false;
		}
	}
}

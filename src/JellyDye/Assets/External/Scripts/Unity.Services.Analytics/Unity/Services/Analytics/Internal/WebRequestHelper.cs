using System;

namespace Unity.Services.Analytics.Internal
{
	internal class WebRequestHelper : IWebRequestHelper
	{
		public IWebRequest CreateWebRequest(string url, string method, byte[] postBytes)
		{
			return null;
		}

		public void SendWebRequest(IWebRequest request, Action<long> onCompleted)
		{
		}
	}
}

using System;

namespace Unity.Services.Analytics.Internal
{
	internal interface IWebRequestHelper
	{
		IWebRequest CreateWebRequest(string url, string method, byte[] postBytes);

		void SendWebRequest(IWebRequest request, Action<long> onCompleted);
	}
}

using UnityEngine.Networking;

namespace Unity.Services.Analytics.Internal
{
	internal interface IWebRequest
	{
		bool isNetworkError { get; }

		UnityWebRequestAsyncOperation SendWebRequest();

		void SetRequestHeader(string key, string value);

		void Dispose();
	}
}

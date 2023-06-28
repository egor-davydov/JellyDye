using System;
using UnityEngine.Networking;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal class UnityWebRequestSender : IUnityWebRequestSender
	{
		public void SendRequest(UnityWebRequest request, Action<WebRequest> callback)
		{
		}

		private static WebRequest Simplify(UnityWebRequest webRequest)
		{
			return default(WebRequest);
		}
	}
}

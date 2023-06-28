using System;
using UnityEngine.Networking;

namespace Unity.Services.Core.Telemetry.Internal
{
	internal interface IUnityWebRequestSender
	{
		void SendRequest(UnityWebRequest request, Action<WebRequest> callback);
	}
}

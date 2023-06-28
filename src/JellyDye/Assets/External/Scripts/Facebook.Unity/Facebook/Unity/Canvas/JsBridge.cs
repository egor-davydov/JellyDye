using UnityEngine;

namespace Facebook.Unity.Canvas
{
	internal class JsBridge : MonoBehaviour
	{
		private ICanvasFacebookCallbackHandler facebook;

		public void Start()
		{
		}

		public void OnLoginComplete(string responseJsonData = "")
		{
		}

		public void OnFacebookAuthResponseChange(string responseJsonData = "")
		{
		}

		public void OnPayComplete(string responseJsonData = "")
		{
		}

		public void OnAppRequestsComplete(string responseJsonData = "")
		{
		}

		public void OnShareLinkComplete(string responseJsonData = "")
		{
		}

		public void OnFacebookFocus(string state)
		{
		}

		public void OnInitComplete(string responseJsonData = "")
		{
		}

		public void OnUrlResponse(string url = "")
		{
		}
	}
}

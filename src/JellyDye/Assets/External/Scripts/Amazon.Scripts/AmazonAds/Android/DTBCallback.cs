using UnityEngine;

namespace AmazonAds.Android
{
	public class DTBCallback : AndroidJavaProxy
	{
		public enum ErrorCode
		{
			NO_ERROR = 0,
			NETWORK_ERROR = 1,
			NETWORK_TIMEOUT = 2,
			NO_FILL = 3,
			INTERNAL_ERROR = 4,
			REQUEST_ERROR = 5
		}

		public Amazon.OnSuccessDelegate onSuccessCallback;

		public Amazon.OnFailureDelegate onFailureCallback;

		public Amazon.OnFailureWithErrorDelegate onFailureWithErrorCallback;

		public DTBCallback()
			: base((string)null)
		{
		}

		private void onSuccess(AndroidJavaObject paramDTBAdResponse)
		{
		}

		private void onFailure(AndroidJavaObject paramAdError)
		{
		}
	}
}

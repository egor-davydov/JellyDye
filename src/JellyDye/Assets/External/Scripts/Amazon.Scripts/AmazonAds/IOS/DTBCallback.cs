using System;

namespace AmazonAds.IOS
{
	public class DTBCallback
	{
		public delegate void OnFailureWithErrorDelegate(IntPtr callback, int errorMsg, IntPtr adError);

		public delegate void OnFailureDelegate(IntPtr callback, int errorMsg);

		public delegate void OnSuccessDelegate(IntPtr callback, IntPtr response);

		public enum ErrorCode
		{
			NO_ERROR = 0,
			NETWORK_ERROR = 1,
			NETWORK_TIMEOUT = 2,
			NO_FILL = 3,
			INTERNAL_ERROR = 4,
			REQUEST_ERROR = 5
		}

		public struct DTBAdResponceData
		{
			public string amznSlots;

			public string mediationHints;

			public string keywords;
		}

		private IntPtr clientPtr;

		private IntPtr thisPtr;

		public Amazon.OnSuccessDelegate onSuccessCallback;

		public Amazon.OnFailureDelegate onFailureCallback;

		public Amazon.OnFailureWithErrorDelegate onFailureWithErrorCallback;

		private AdRequest refreshAdLoader;

		public DTBCallback(Amazon.OnFailureDelegate failureDelegate, Amazon.OnSuccessDelegate successDelegate)
		{
		}

		public DTBCallback(Amazon.OnFailureWithErrorDelegate failureWithErrorDelegate, Amazon.OnSuccessDelegate successDelegate)
		{
		}

		public IntPtr GetPtr()
		{
			return (IntPtr)0;
		}

		private static DTBCallback IntPtrToClient(IntPtr callbackClient)
		{
			return null;
		}

		public static void OnSuccess(IntPtr callbackClient, IntPtr response)
		{
		}

		public static void OnFailure(IntPtr callbackClient, int errorMsg)
		{
		}

		public static void OnFailureWithInfo(IntPtr callbackClient, int errorMsg, IntPtr errorInfo)
		{
		}
	}
}

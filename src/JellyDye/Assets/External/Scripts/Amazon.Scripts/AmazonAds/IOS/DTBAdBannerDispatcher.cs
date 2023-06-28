using System;

namespace AmazonAds.IOS
{
	public class DTBAdBannerDispatcher
	{
		public delegate void OnAdLoadedDelegate(IntPtr callback);

		public delegate void OnAdFailedDelegate(IntPtr callback);

		public delegate void OnAdClickedDelegate(IntPtr callback);

		public delegate void OnImpressionFiredDelegate(IntPtr callback);

		private IntPtr clientPtr;

		private IntPtr thisPtr;

		public APSAdDelegate adDelegate;

		public DTBAdBannerDispatcher(APSAdDelegate delegates)
		{
		}

		public IntPtr GetPtr()
		{
			return (IntPtr)0;
		}

		private static DTBAdBannerDispatcher IntPtrToClient(IntPtr client)
		{
			return null;
		}

		public static void OnAdLoaded(IntPtr client)
		{
		}

		public static void OnAdFailed(IntPtr client)
		{
		}

		public static void OnAdClicked(IntPtr client)
		{
		}

		public static void OnImpressionFired(IntPtr client)
		{
		}
	}
}

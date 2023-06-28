using UnityEngine;

namespace AmazonAds.Android
{
	public class DTBAdInterstitialListener : AndroidJavaProxy
	{
		public APSAdDelegate adDelegate;

		public DTBAdInterstitialListener()
			: base((string)null)
		{
		}

		private void onAdLoaded(AndroidJavaObject paramObject)
		{
		}

		private void onAdFailed(AndroidJavaObject paramObject)
		{
		}

		private void onAdClicked(AndroidJavaObject paramObject)
		{
		}

		private void onAdOpen(AndroidJavaObject paramObject)
		{
		}

		private void onAdClosed(AndroidJavaObject paramObject)
		{
		}

		private void onImpressionFired(AndroidJavaObject paramObject)
		{
		}

		private void onAdLeftApplication(AndroidJavaObject paramObject)
		{
		}

		private void onVideoCompleted(AndroidJavaObject paramObject)
		{
		}
	}
}

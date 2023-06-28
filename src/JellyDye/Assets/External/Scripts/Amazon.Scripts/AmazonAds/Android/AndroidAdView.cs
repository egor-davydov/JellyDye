using UnityEngine;

namespace AmazonAds.Android
{
	public class AndroidAdView : IAdView
	{
		private AndroidJavaObject dtbAdView;

		private static readonly AndroidJavaClass SDKUtilitiesClass;

		public AndroidAdView(APSAdDelegate delegates)
		{
		}

		public override void FetchAd(AdResponse adResponse)
		{
		}
	}
}

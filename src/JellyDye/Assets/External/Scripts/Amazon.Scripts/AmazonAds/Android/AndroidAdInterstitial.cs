using UnityEngine;

namespace AmazonAds.Android
{
	public class AndroidAdInterstitial : IAdInterstitial
	{
		private AndroidJavaObject dtbAdInterstitial;

		private static readonly AndroidJavaClass SDKUtilitiesClass;

		public AndroidAdInterstitial(APSAdDelegate delegates)
		{
		}

		public override void FetchAd(AdResponse adResponse)
		{
		}

		public override void Show()
		{
		}
	}
}

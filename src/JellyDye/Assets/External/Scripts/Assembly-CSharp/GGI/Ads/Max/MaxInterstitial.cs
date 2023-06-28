using System;
using AmazonAds;

namespace GGI.Ads.Max
{
	public class MaxInterstitial : InterstitialAd
	{
		private bool _shown;

		private DateTime _adRequestStartTime;

		private APSVideoAdRequest interstitialVideoAdRequest;

		private bool isFirstInterstitialRequest;

		public MaxInterstitial(string adUnit, bool autoFetch)
			: base(null, autoFetch: false)
		{
		}

		protected override void Request()
		{
		}

		public override void Show()
		{
		}

		private void ShowTimeout()
		{
		}

		protected override void RegisterEvents()
		{
		}

		protected override void UnregisterEvents()
		{
		}

		private void OnMoPubShownEvent(string adUnit)
		{
		}

		private void OnMoPubLoadedEvent(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnMoPubClickedEvent(string adUnit)
		{
		}

		private void OnMoPubClosedEvent(string adUnit)
		{
		}

		private void OnMoPubExpiredEvent(string adUnit)
		{
		}

		private void OnMoPubFailedEvent(string adUnit, int error)
		{
		}

		public override bool IsLoaded()
		{
			return false;
		}
	}
}

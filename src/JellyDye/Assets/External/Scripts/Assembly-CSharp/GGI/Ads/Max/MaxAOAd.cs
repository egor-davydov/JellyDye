using System;
using AmazonAds;

namespace GGI.Ads.Max
{
	public class MaxAOAd : AOAd
	{
		private bool _shown;

		private DateTime _adRequestStartTime;

		private APSVideoAdRequest interstitialVideoAdRequest;

		private bool isFirstInterstitialRequest;

		public MaxAOAd(string adUnit, bool autoFetch)
			: base(null, autoFetch: false)
		{
		}

		protected override void Request()
		{
		}

		public override void Show()
		{
		}

		protected override void RegisterEvents()
		{
		}

		protected override void UnregisterEvents()
		{
		}

		private void OnAdDisplayedEvent(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnMoPubLoadedEvent(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAdClickedEvent(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAdHiddenEvent(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAdLoadFailedEvent(string adUnit, MaxSdkBase.ErrorInfo err)
		{
		}

		private void OnAdDisplayFailedEvent(string adUnit, MaxSdkBase.ErrorInfo err, MaxSdkBase.AdInfo adInfo)
		{
		}

		public override bool IsLoaded()
		{
			return false;
		}
	}
}

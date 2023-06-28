using System;
using AmazonAds;

namespace GGI.Ads.Max
{
	public class MaxBanner : BannerAd
	{
		private DateTime _adRequestStartTime;

		private APSBannerAdRequest bannerAdRequest;

		public MaxBanner(string adUnit)
			: base(null, autoFetch: false)
		{
		}

		private void SetAmazonBanner(string adUnit)
		{
		}

		public void CreateBanner(string adUnit)
		{
		}

		public override void Show()
		{
		}

		public override void Hide()
		{
		}

		public override void Destroy()
		{
		}

		protected override void RegisterEvents()
		{
		}

		protected override void UnregisterEvents()
		{
		}

		private void OnMoPubAdFailed(string adUnit, int error)
		{
		}

		private void OnMoPubAdLoaded(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnMoPubAdClicked(string adUnit)
		{
		}
	}
}

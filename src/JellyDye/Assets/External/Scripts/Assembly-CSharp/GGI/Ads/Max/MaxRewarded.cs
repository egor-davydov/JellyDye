using System;
using AmazonAds;

namespace GGI.Ads.Max
{
	public class MaxRewarded : RewardedAd
	{
		private DateTime _adRequestStartTime;

		private bool _receivedReward;

		private APSVideoAdRequest rewardedVideoAdRequest;

		private bool isFirstRewardedVideoRequest;

		public MaxRewarded(string adUnit, bool autoFetch)
			: base(null, autoFetch: false)
		{
		}

		protected override void Request()
		{
		}

		public override void Show()
		{
		}

		public override bool IsLoaded()
		{
			return false;
		}

		protected override void RegisterEvents()
		{
		}

		protected override void UnregisterEvents()
		{
		}

		private void OnMoPubLoadedEvent(string adUnit, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnMoPubFailedEvent(string adUnit, MaxSdkBase.ErrorInfo error)
		{
		}

		private void OnMoPubFailedToPlayEvent(string adUnit, MaxSdkBase.ErrorInfo error, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnMoPubReceivedRewardEvent(string adunit, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void OnAdHidden(string adUnit, MaxSdkBase.AdInfo info)
		{
		}

		private void OnMoPubShownEvent(string adUnit, MaxSdkBase.AdInfo info)
		{
		}

		private void OnMoPubClickedEvent(string adUnit, MaxSdkBase.AdInfo info)
		{
		}
	}
}

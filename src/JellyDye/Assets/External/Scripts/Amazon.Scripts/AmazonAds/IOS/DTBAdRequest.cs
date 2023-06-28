using System;

namespace AmazonAds.IOS
{
	public class DTBAdRequest : IAdRequest
	{
		private IntPtr adLoader;

		private string _slotGroupName;

		private IAdSize _bannerAdSize;

		private IInterstitialAdSize _interstitialAdSize;

		private IVideo _videoAdSize;

		public DTBAdRequest()
		{
		}

		public DTBAdRequest(IntPtr adRequest)
		{
		}

		public IntPtr GetInstance()
		{
			return (IntPtr)0;
		}

		public override void DisposeAd()
		{
		}

		public override void LoadAd(Amazon.OnFailureDelegate failure, Amazon.OnSuccessDelegate success)
		{
		}

		public override void LoadSmartBanner(Amazon.OnFailureDelegate failure, Amazon.OnSuccessDelegate success)
		{
		}

		public override void LoadAd(Amazon.OnFailureWithErrorDelegate failureWithError, Amazon.OnSuccessDelegate success)
		{
		}

		public override void LoadSmartBanner(Amazon.OnFailureWithErrorDelegate failureWithError, Amazon.OnSuccessDelegate success)
		{
		}

		public override void PutCustomTarget(string key, string value)
		{
		}

		public override void SetAutoRefresh()
		{
		}

		public override void SetAutoRefresh(int secs)
		{
		}

		public override void PauseAutoRefresh()
		{
		}

		public override void StopAutoRefresh()
		{
		}

		public override void ResumeAutoRefresh()
		{
		}

		public override void SetAutoRefreshMoPub(bool flag)
		{
		}

		public override void SetAutoRefreshMoPub(bool flag, int refreshTime)
		{
		}

		public override void SetAutoRefreshAdMob(bool flag, bool isSmartBanner = false)
		{
		}

		public override void SetRefreshFlag(bool flag)
		{
		}

		public override void StartFetchManager()
		{
		}

		public override void StopFetchManager()
		{
		}

		public override void CreateFetchManager(bool isSmartBanner = false)
		{
		}

		public override void DestroyFetchManager()
		{
		}

		public override void SetSizes(IAdSize sizes)
		{
		}

		public override void SetSizes(IInterstitialAdSize sizes)
		{
		}

		public override void SetSizes(IVideo sizes)
		{
		}

		public override void SetSlotGroup(string slotGroupName)
		{
		}

		public IAdSize GetBannerAdSizes()
		{
			return null;
		}

		public IInterstitialAdSize GetInterstitialSizes()
		{
			return null;
		}

		public IVideo GetVideoSizes()
		{
			return null;
		}

		public string GetSlotGroup()
		{
			return null;
		}
	}
}

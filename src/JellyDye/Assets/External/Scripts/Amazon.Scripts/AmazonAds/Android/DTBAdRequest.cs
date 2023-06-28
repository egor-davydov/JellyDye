using UnityEngine;

namespace AmazonAds.Android
{
	public class DTBAdRequest : IAdRequest
	{
		private AndroidJavaObject dTBAdRequest;

		private string _slotGroupName;

		private IAdSize _bannerAdSize;

		private IInterstitialAdSize _interstitialAdSize;

		private IVideo _videoAdSize;

		public DTBAdRequest()
		{
		}

		public DTBAdRequest(AndroidJavaObject dtbRequest)
		{
		}

		public override void PutCustomTarget(string key, string value)
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

		public override void LoadAd(Amazon.OnFailureDelegate failure, Amazon.OnSuccessDelegate success)
		{
		}

		public override void LoadSmartBanner(Amazon.OnFailureDelegate failure, Amazon.OnSuccessDelegate success)
		{
		}

		public override void LoadAd(Amazon.OnFailureWithErrorDelegate failure, Amazon.OnSuccessDelegate success)
		{
		}

		public override void LoadSmartBanner(Amazon.OnFailureWithErrorDelegate failure, Amazon.OnSuccessDelegate success)
		{
		}

		private DTBCallback createLoadAdCallback(Amazon.OnSuccessDelegate success)
		{
			return null;
		}

		public AndroidJavaObject GetClient()
		{
			return null;
		}

		public override void SetAutoRefresh()
		{
		}

		public override void SetAutoRefresh(int secs)
		{
		}

		public override void ResumeAutoRefresh()
		{
		}

		public override void StopAutoRefresh()
		{
		}

		public override void PauseAutoRefresh()
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

		public override void DisposeAd()
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
	}
}

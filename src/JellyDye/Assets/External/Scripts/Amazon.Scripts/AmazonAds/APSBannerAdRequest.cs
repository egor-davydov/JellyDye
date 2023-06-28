namespace AmazonAds
{
	public class APSBannerAdRequest : AdRequest
	{
		public APSBannerAdRequest()
		{
		}

		public APSBannerAdRequest(string slotGroupName)
		{
		}

		public APSBannerAdRequest(int width, int height, string uid)
		{
		}

		public APSBannerAdRequest(AdSize size)
		{
		}

		public void LoadSmartBanner()
		{
		}

		public void SetSizes(int width, int height, string uid)
		{
		}

		public void SetSizes(AdSize size)
		{
		}

		public void SetSlotGroup(string slotGroupName)
		{
		}

		public void SetAutoRefreshAdMob(bool flag, bool isSmartBanner = false)
		{
		}

		public void SetAutoRefreshMoPub(bool flag, int refreshTime)
		{
		}

		public void DisposeAd()
		{
		}

		public void IsAutoRefreshAdMob()
		{
		}

		public void IsAutoRefreshMoPub()
		{
		}

		public string AutoRefreshID()
		{
			return null;
		}

		public void CreateFetchManager(bool isSmartBanner = false)
		{
		}

		public void DestroyFetchManager()
		{
		}

		public void OnApplicationPause(bool isPaused)
		{
		}
	}
}

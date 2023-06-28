namespace AmazonAds
{
	public class APSMediationUtils
	{
		public class APSIronSourceNetworkInterstitialInputData
		{
			public string uuid;

			public string pricePointEncoded;

			public string bidInfo;
		}

		public class APSIronSourceNetworkBannerInputData
		{
			public string bidInfo;

			public string pricePointEncoded;

			public string uuid;

			public int width;

			public int height;
		}

		public class APSIronSourceBannerNetworkData
		{
			public APSIronSourceNetworkBannerInputData banner;
		}

		public class APSIronSourceInterstitialNetworkData
		{
			public APSIronSourceNetworkInterstitialInputData interstitial;
		}

		public static string APS_IRON_SOURCE_NETWORK_KEY;

		public static string GetInterstitialNetworkData(string amazonSlotId, AdResponse adResponse)
		{
			return null;
		}

		public static string GetBannerNetworkData(string amazonSlotId, AdResponse adResponse)
		{
			return null;
		}

		private APSMediationUtils()
		{
		}
	}
}

using AmazonAds;
using UnityEngine;
using UnityEngine.UI;

public class AmazonMaxDemo : MonoBehaviour
{
	private const string maxKey = "l-_TbRRFRIhI2bN388lTNzh0k_83nqhSLMkFs2ATgT_y4GPxCqSQOdiDV3WgHf01C4N9r53JvUp-N_65kdcdro";

	private const string appId = "7873ab072f0647b8837748312c7b8b5a";

	private const string maxBannerAdId = "989798cb31a0d25f";

	private const string maxInterstitialAdId = "7e3a01318c888038";

	private const string maxVideoAdId = "09d9041492d1d0d9";

	private const string amazonBannerSlotId = "ed3b9f16-4497-4001-be7d-2e8ca679ee73";

	private const string amzonInterstitialSlotId = "394133e6-27fe-477d-816b-4a00cdaa54b6";

	private const string amazonInterstitialVideoSlotId = "b9f9a2aa-72d8-4cb3-83db-949ebb53836f";

	private const string amazonRewardedVideoSlotId = "1ed9fa0b-3cf0-4326-8c35-c0e9ddcdb765";

	public Button isInitializedBut;

	private bool isAutoRefresh;

	private bool isFirstInterstitialRequest;

	private bool isFirstVideoInterstitialRequest;

	private bool isFirstRewardedVideoRequest;

	private APSBannerAdRequest bannerAdRequest;

	private APSInterstitialAdRequest interstitialAdRequest;

	private APSVideoAdRequest interstitialVideoAdRequest;

	private APSVideoAdRequest rewardedVideoAdRequest;

	public void InitializeMax()
	{
	}

	public void IsInitialized()
	{
	}

	public void RequestInterstitial()
	{
	}

	private void CreateMaxBannerAd()
	{
	}

	public void RequestBanner()
	{
	}

	public void RequestInterstitialVideo()
	{
	}

	public void RequestRewardedVideo()
	{
	}

	private void OnBannerAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnBannerAdLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnBannerAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnBannerAdExpandedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnBannerAdCollapsedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnInterstitialDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void ShowRewardedAd()
	{
	}

	private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
	{
	}

	private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
	{
	}

	private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
	{
	}
}

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using GGI.Ads;
using GGI.Components;

namespace GGI.Core
{
	public class GGIAds : AutoSingleton<GGIAds>
	{
		public enum MediationMode
		{
			MoPub = 0,
			Admob = 1
		}

		private InterstitialAd _interstitialAd;

		private RewardedAd _rewardedAd;

		private BannerAd _bannerAd;

		private AOAd _appOpenAd;

		private AdConditions _adConditions;

		private string _interstitialAdUnit;

		private string _bannerAdUnit;

		private string _rewardedAdUnit;

		private string _aoAdUnit;

		private bool _bannerShouldShow;

		private bool _bannerShown;

		private Action<float> _bannerCallback;

		private string _lastRewardedPlace;

		private long _lastRewardedCalledFromClient;

		private bool _initComplete;

		private MediationMode _mediationMode;

		public Action AdsRequested;

		public event Action OnBeforeInterstitialShown
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnBeforeRewardedShown
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public string GetAOAdUnit()
		{
			return null;
		}

		public string GetAdId()
		{
			return null;
		}

		public void SetAdId(string adId)
		{
		}

		public bool IsRewardedLoaded(bool logMissedOpportunity = false)
		{
			return false;
		}

		private void MAXSDKInitialized(MaxSdkBase.SdkConfiguration sdkConfiguration)
		{
		}

		private void RequestAds()
		{
		}

		public string GetAmazonBannerSlotId()
		{
			return null;
		}

		public string GetAmazonInterstitialSlotId()
		{
			return null;
		}

		public string GetAmazonRewardedSlotId()
		{
			return null;
		}

		public string GetAmazonAppId()
		{
			return null;
		}

		public bool IsAmazonEnabled()
		{
			return false;
		}

		public void Init(MediationMode mediationMode)
		{
		}

		private void AdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void AdRevenuePaidAdjustEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
		{
		}

		private void SetAdUnit(AdUnitType unitType, string adUnit)
		{
		}

		private IEnumerator ShowAOAdInternal()
		{
			return null;
		}

		private IEnumerator ShowInterstitialAdFromAppOpenInternal()
		{
			return null;
		}

		public void ShowAO(Action onComplete)
		{
		}

		public void ShowInterstitial(Action onComplete, bool ignoreConditions = false, bool isAppOpen = false)
		{
		}

		public void ShowRewardedVideo(Action<bool> onComplete, string rewardedPlace)
		{
		}

		public void ShowBanner(Action<float> onBannerDisplayed)
		{
		}

		public void HideBanner()
		{
		}

		private void OnBannerLoaded()
		{
		}

		private void OnInterLoaded()
		{
		}

		private void OnRewardedLoaded()
		{
		}

		public bool IsBannerShowing()
		{
			return false;
		}

		public bool IsInterstitialAvailable()
		{
			return false;
		}

		public bool IsRewardedShowing()
		{
			return false;
		}

		public bool IsInterstitialShowing()
		{
			return false;
		}

		public void UpdateInterstitialUnit(string adUnit)
		{
		}

		public void UpdateRewardedAdUnit(string adUnit)
		{
		}

		public void UpdateBannerAdUnit(string adUnit)
		{
		}

		public void UpdateAOAdUnit(string adUnit)
		{
		}

		public void DestroyIntersitital()
		{
		}

		public void DestroyAppOpen()
		{
		}

		public void DestroyRewarded()
		{
		}

		public void DestroyBanner()
		{
		}

		public AdConditions GetAdConditions()
		{
			return null;
		}

		private bool HasFirebaseRemoteConfigAdConditionsOverride(string key)
		{
			return false;
		}

		public GGIAds()
		{
			((AutoSingleton<>)(object)this)._002Ector();
		}
	}
}

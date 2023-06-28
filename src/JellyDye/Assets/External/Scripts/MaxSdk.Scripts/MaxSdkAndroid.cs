using System;
using System.Collections.Generic;
using UnityEngine;

public class MaxSdkAndroid : MaxSdkBase
{
	internal class BackgroundCallbackProxy : AndroidJavaProxy
	{
		public BackgroundCallbackProxy()
			: base((string)null)
		{
		}

		public void onEvent(string propsStr)
		{
		}
	}

	private static readonly AndroidJavaClass MaxUnityPluginClass;

	private static BackgroundCallbackProxy BackgroundCallback;

	public static MaxVariableServiceAndroid VariableService => null;

	public static MaxUserServiceAndroid UserService => null;

	public static MaxUserSegment UserSegment => null;

	public static MaxTargetingData TargetingData => null;

	static MaxSdkAndroid()
	{
	}

	public static void SetSdkKey(string sdkKey)
	{
	}

	public static void InitializeSdk(string[] adUnitIds = null)
	{
	}

	public static bool IsInitialized()
	{
		return false;
	}

	public static void SetUserId(string userId)
	{
	}

	public static List<MediatedNetworkInfo> GetAvailableMediatedNetworks()
	{
		return null;
	}

	public static void ShowMediationDebugger()
	{
	}

	public static string GetAdValue(string adUnitIdentifier, string key)
	{
		return null;
	}

	public static SdkConfiguration GetSdkConfiguration()
	{
		return null;
	}

	public static void SetHasUserConsent(bool hasUserConsent)
	{
	}

	public static bool HasUserConsent()
	{
		return false;
	}

	public static bool IsUserConsentSet()
	{
		return false;
	}

	public static void SetIsAgeRestrictedUser(bool isAgeRestrictedUser)
	{
	}

	public static bool IsAgeRestrictedUser()
	{
		return false;
	}

	public static bool IsAgeRestrictedUserSet()
	{
		return false;
	}

	public static void SetDoNotSell(bool doNotSell)
	{
	}

	public static bool IsDoNotSell()
	{
		return false;
	}

	public static bool IsDoNotSellSet()
	{
		return false;
	}

	public static void CreateBanner(string adUnitIdentifier, BannerPosition bannerPosition)
	{
	}

	public static void CreateBanner(string adUnitIdentifier, float x, float y)
	{
	}

	public static void SetBannerPlacement(string adUnitIdentifier, string placement)
	{
	}

	public static void StartBannerAutoRefresh(string adUnitIdentifier)
	{
	}

	public static void StopBannerAutoRefresh(string adUnitIdentifier)
	{
	}

	public static void UpdateBannerPosition(string adUnitIdentifier, BannerPosition bannerPosition)
	{
	}

	public static void UpdateBannerPosition(string adUnitIdentifier, float x, float y)
	{
	}

	public static void SetBannerWidth(string adUnitIdentifier, float width)
	{
	}

	public static void ShowBanner(string adUnitIdentifier)
	{
	}

	public static void DestroyBanner(string adUnitIdentifier)
	{
	}

	public static void HideBanner(string adUnitIdentifier)
	{
	}

	public static void SetBannerBackgroundColor(string adUnitIdentifier, Color color)
	{
	}

	public static void SetBannerExtraParameter(string adUnitIdentifier, string key, string value)
	{
	}

	public static void SetBannerLocalExtraParameter(string adUnitIdentifier, string key, object value)
	{
	}

	public static void SetBannerCustomData(string adUnitIdentifier, string customData)
	{
	}

	public static Rect GetBannerLayout(string adUnitIdentifier)
	{
		return default(Rect);
	}

	public static void CreateMRec(string adUnitIdentifier, AdViewPosition mrecPosition)
	{
	}

	public static void CreateMRec(string adUnitIdentifier, float x, float y)
	{
	}

	public static void SetMRecPlacement(string adUnitIdentifier, string placement)
	{
	}

	public static void StartMRecAutoRefresh(string adUnitIdentifier)
	{
	}

	public static void StopMRecAutoRefresh(string adUnitIdentifier)
	{
	}

	public static void UpdateMRecPosition(string adUnitIdentifier, AdViewPosition mrecPosition)
	{
	}

	public static void UpdateMRecPosition(string adUnitIdentifier, float x, float y)
	{
	}

	public static void ShowMRec(string adUnitIdentifier)
	{
	}

	public static void DestroyMRec(string adUnitIdentifier)
	{
	}

	public static void HideMRec(string adUnitIdentifier)
	{
	}

	public static void SetMRecExtraParameter(string adUnitIdentifier, string key, string value)
	{
	}

	public static void SetMRecLocalExtraParameter(string adUnitIdentifier, string key, object value)
	{
	}

	public static void SetMRecCustomData(string adUnitIdentifier, string customData)
	{
	}

	public static Rect GetMRecLayout(string adUnitIdentifier)
	{
		return default(Rect);
	}

	public static void CreateCrossPromoAd(string adUnitIdentifier, float x, float y, float width, float height, float rotation)
	{
	}

	public static void SetCrossPromoAdPlacement(string adUnitIdentifier, string placement)
	{
	}

	public static void UpdateCrossPromoAdPosition(string adUnitIdentifier, float x, float y, float width, float height, float rotation)
	{
	}

	public static void ShowCrossPromoAd(string adUnitIdentifier)
	{
	}

	public static void DestroyCrossPromoAd(string adUnitIdentifier)
	{
	}

	public static void HideCrossPromoAd(string adUnitIdentifier)
	{
	}

	public static Rect GetCrossPromoAdLayout(string adUnitIdentifier)
	{
		return default(Rect);
	}

	public static void LoadInterstitial(string adUnitIdentifier)
	{
	}

	public static bool IsInterstitialReady(string adUnitIdentifier)
	{
		return false;
	}

	public static void ShowInterstitial(string adUnitIdentifier, string placement = null, string customData = null)
	{
	}

	public static void SetInterstitialExtraParameter(string adUnitIdentifier, string key, string value)
	{
	}

	public static void SetInterstitialLocalExtraParameter(string adUnitIdentifier, string key, object value)
	{
	}

	public static void LoadAppOpenAd(string adUnitIdentifier)
	{
	}

	public static bool IsAppOpenAdReady(string adUnitIdentifier)
	{
		return false;
	}

	public static void ShowAppOpenAd(string adUnitIdentifier, string placement = null, string customData = null)
	{
	}

	public static void SetAppOpenAdExtraParameter(string adUnitIdentifier, string key, string value)
	{
	}

	public static void SetAppOpenAdLocalExtraParameter(string adUnitIdentifier, string key, object value)
	{
	}

	public static void LoadRewardedAd(string adUnitIdentifier)
	{
	}

	public static bool IsRewardedAdReady(string adUnitIdentifier)
	{
		return false;
	}

	public static void ShowRewardedAd(string adUnitIdentifier, string placement = null, string customData = null)
	{
	}

	public static void SetRewardedAdExtraParameter(string adUnitIdentifier, string key, string value)
	{
	}

	public static void SetRewardedAdLocalExtraParameter(string adUnitIdentifier, string key, object value)
	{
	}

	public static void LoadRewardedInterstitialAd(string adUnitIdentifier)
	{
	}

	public static bool IsRewardedInterstitialAdReady(string adUnitIdentifier)
	{
		return false;
	}

	public static void ShowRewardedInterstitialAd(string adUnitIdentifier, string placement = null, string customData = null)
	{
	}

	public static void SetRewardedInterstitialAdExtraParameter(string adUnitIdentifier, string key, string value)
	{
	}

	public static void SetRewardedInterstitialAdLocalExtraParameter(string adUnitIdentifier, string key, object value)
	{
	}

	public static void TrackEvent(string name, IDictionary<string, string> parameters = null)
	{
	}

	public static void SetMuted(bool muted)
	{
	}

	public static bool IsMuted()
	{
		return false;
	}

	public static void SetVerboseLogging(bool enabled)
	{
	}

	public static bool IsVerboseLoggingEnabled()
	{
		return false;
	}

	public static void SetCreativeDebuggerEnabled(bool enabled)
	{
	}

	public static void SetTestDeviceAdvertisingIdentifiers(string[] advertisingIdentifiers)
	{
	}

	public static void SetExceptionHandlerEnabled(bool enabled)
	{
	}

	public static void SetLocationCollectionEnabled(bool enabled)
	{
	}

	public static void SetExtraParameter(string key, string value)
	{
	}

	internal static void SetUserSegmentField(string name, string value)
	{
	}

	internal static void SetTargetingDataYearOfBirth(int yearOfBirth)
	{
	}

	internal static void SetTargetingDataGender(string gender)
	{
	}

	internal static void SetTargetingDataMaximumAdContentRating(int maximumAdContentRating)
	{
	}

	internal static void SetTargetingDataEmail(string email)
	{
	}

	internal static void SetTargetingDataPhoneNumber(string phoneNumber)
	{
	}

	internal static void SetTargetingDataKeywords(string[] keywords)
	{
	}

	internal static void SetTargetingDataInterests(string[] interests)
	{
	}

	internal static void ClearAllTargetingData()
	{
	}

	[Obsolete]
	public static ConsentDialogState GetConsentDialogState()
	{
		return default(ConsentDialogState);
	}

	[Obsolete]
	public static AdInfo GetAdInfo(string adUnitIdentifier)
	{
		return null;
	}
}

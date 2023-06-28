using System;

namespace AmazonAds.IOS
{
	public class Externs
	{
		public static void _amazonInitialize(string appKey)
		{
		}

		public static bool _amazonIsInitialized()
		{
			return false;
		}

		public static void _amazonSetUseGeoLocation(bool flag)
		{
		}

		public static bool _amazonGetUseGeoLocation()
		{
			return false;
		}

		public static void _amazonSetLogLevel(int logLevel)
		{
		}

		public static bool _amazonGetLogLevel()
		{
			return false;
		}

		public static void _amazonSetTestMode(bool flag)
		{
		}

		public static bool _amazonIsTestModeEnabled()
		{
			return false;
		}

		public static IntPtr _createBannerAdSize(int width, int height, string uuid)
		{
			return (IntPtr)0;
		}

		public static IntPtr _createVideoAdSize(int width, int height, string uuid)
		{
			return (IntPtr)0;
		}

		public static IntPtr _createInterstitialAdSize(string uuid)
		{
			return (IntPtr)0;
		}

		public static IntPtr _createAdLoader()
		{
			return (IntPtr)0;
		}

		public static void _setSizes(IntPtr adLoader, IntPtr size)
		{
		}

		public static void _loadAd(IntPtr adLoader, IntPtr callback)
		{
		}

		public static void _loadSmartBanner(IntPtr adLoader, IntPtr callback)
		{
		}

		public static void _amazonSetListeners(IntPtr unityRef, IntPtr callback, DTBCallback.OnSuccessDelegate onSuccessCallback, DTBCallback.OnFailureDelegate onErrorCallback)
		{
		}

		public static void _amazonSetListenersWithInfo(IntPtr unityRef, IntPtr callback, DTBCallback.OnSuccessDelegate onSuccessCallback, DTBCallback.OnFailureWithErrorDelegate onErrorCallbackWithInfo)
		{
		}

		public static void _setBannerDelegate(IntPtr unityRef, IntPtr callback, DTBAdBannerDispatcher.OnAdLoadedDelegate onAdLoadedDelegate, DTBAdBannerDispatcher.OnAdFailedDelegate onAdFailedDelegate, DTBAdBannerDispatcher.OnAdClickedDelegate onAdClickedDelegate, DTBAdBannerDispatcher.OnImpressionFiredDelegate onImpressionFiredDelegate)
		{
		}

		public static void _setInterstitialDelegate(IntPtr unityRef, IntPtr callback, DTBAdInterstitialDispatcher.OnAdLoadedDelegate onAdLoadedDelegate, DTBAdInterstitialDispatcher.OnAdFailedDelegate onAdFailedDelegate, DTBAdInterstitialDispatcher.OnAdClickedDelegate onAdClickedDelegate, DTBAdInterstitialDispatcher.OnImpressionFiredDelegate onImpressionFiredDelegate, DTBAdInterstitialDispatcher.OnAdOpenDelegate onAdOpenDelegate, DTBAdInterstitialDispatcher.OnAdClosedDelegate onAdClosedDelegate)
		{
		}

		public static void _amazonSetMRAIDPolicy(int policy)
		{
		}

		public static int _amazonGetMRAIDPolicy()
		{
			return 0;
		}

		public static void _amazonSetMRAIDSupportedVersions(string versions)
		{
		}

		public static IntPtr _createCallback()
		{
			return (IntPtr)0;
		}

		public static IntPtr _createBannerDelegate()
		{
			return (IntPtr)0;
		}

		public static IntPtr _createInterstitialDelegate()
		{
			return (IntPtr)0;
		}

		public static IntPtr _getFetchManager(int autoRefreshID, bool isSmartBanner)
		{
			return (IntPtr)0;
		}

		public static void _fetchManagerPop(IntPtr fetchManager)
		{
		}

		public static void _putCustomTarget(IntPtr adLoader, string key, string value)
		{
		}

		public static void _createFetchManager(IntPtr adLoader, bool isSmartBanner)
		{
		}

		public static void _startFetchManager(IntPtr fetchManager)
		{
		}

		public static void _stopFetchManager(IntPtr fetchManager)
		{
		}

		public static bool _isEmptyFetchManager(IntPtr fetchManager)
		{
			return false;
		}

		public static void _destroyFetchManager(int autoRefreshID)
		{
		}

		public static void _setSlotGroup(IntPtr adLoader, string slotGroupName)
		{
		}

		public static IntPtr _createSlotGroup(string slotGroupName)
		{
			return (IntPtr)0;
		}

		public static void _addSlot(IntPtr slot, IntPtr size)
		{
		}

		public static void _addSlotGroup(IntPtr group)
		{
		}

		public static string _fetchMediationHints(IntPtr resp, bool isSmartBanner)
		{
			return null;
		}

		public static string _fetchAmznSlots(IntPtr resp)
		{
			return null;
		}

		public static string _fetchMoPubKeywords(IntPtr resp)
		{
			return null;
		}

		public static void _setCMPFlavor(int cFlavor)
		{
		}

		public static void _setConsentStatus(int consentStatus)
		{
		}

		public static IntPtr _createArray()
		{
			return (IntPtr)0;
		}

		public static void _addToArray(IntPtr dictionary, int item)
		{
		}

		public static void _setVendorList(IntPtr dictionary)
		{
		}

		public static void _setAutoRefreshNoArgs(IntPtr adLoader)
		{
		}

		public static void _setAutoRefresh(IntPtr adLoader, int secs)
		{
		}

		public static void _pauseAutoRefresh(IntPtr adLoader)
		{
		}

		public static void _stopAutoRefresh(IntPtr adLoader)
		{
		}

		public static void _resumeAutoRefresh(IntPtr adLoader)
		{
		}

		public static void _setAPSFrequencyCappingIdFeatureEnabled(bool frequencyCappingIdFeatureEnabled)
		{
		}

		public static void _addCustomAttribute(string withKey, string value)
		{
		}

		public static void _removeCustomAttribute(string forKey)
		{
		}

		public static void _setAdNetworkInfo(int adNetwork)
		{
		}

		public static void _setLocalExtras(string adUnitId, IntPtr localExtras)
		{
		}

		public static IntPtr _createAdView(int width, int height, IntPtr dispatcher)
		{
			return (IntPtr)0;
		}

		public static IntPtr _createAdInterstitial(IntPtr dispatcher)
		{
			return (IntPtr)0;
		}

		public static void _fetchBannerAd(IntPtr adDispatcher, IntPtr adResponse)
		{
		}

		public static void _fetchInterstitialAd(IntPtr adDispatcher, IntPtr adResponse)
		{
		}

		public static void _showInterstitial(IntPtr adDispatcher)
		{
		}

		public static void _setRefreshFlag(IntPtr adLoader, bool flag)
		{
		}

		public static IntPtr _getAdLoaderFromResponse(IntPtr response)
		{
			return (IntPtr)0;
		}

		public static IntPtr _getAdLoaderFromAdError(IntPtr adErrorInfo)
		{
			return (IntPtr)0;
		}

		public static int _fetchAdWidth(IntPtr resp)
		{
			return 0;
		}

		public static int _fetchAdHeight(IntPtr resp)
		{
			return 0;
		}
	}
}

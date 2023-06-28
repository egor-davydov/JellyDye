using System.Collections.Generic;

namespace AmazonAds
{
	public class Amazon
	{
		public delegate void OnFailureDelegate(string errorMsg);

		public delegate void OnFailureWithErrorDelegate(AdError adError);

		public delegate void OnSuccessDelegate(AdResponse response);

		public delegate void OnApplicationPauseDelegate(bool pauseStatus);

		public enum MRAIDPolicy
		{
			AUTO_DETECT = 0,
			MOPUB = 1,
			DFP = 2,
			CUSTOM = 3,
			NONE = 4
		}

		public enum ConsentStatus
		{
			CONSENT_NOT_DEFINED = 0,
			EXPLICIT_YES = 1,
			EXPLICIT_NO = 2,
			UNKNOWN = 3
		}

		public enum CMPFlavor
		{
			CMP_NOT_DEFINED = 0,
			GOOGLE_CMP = 1,
			MOPUB_CMP = 2
		}

		private static PlatformApi api;

		public static OnApplicationPauseDelegate OnApplicationPause;

		public static void Initialize(string key)
		{
		}

		public static void SetMRAIDPolicy(MRAIDPolicy policy)
		{
		}

		public static void SetCMPFlavor(CMPFlavor cFlavor)
		{
		}

		public static void SetConsentStatus(ConsentStatus consentStatus)
		{
		}

		public static void SetVendorList(List<int> vendorList)
		{
		}

		public static void AddSlotGroup(SlotGroup group)
		{
		}

		public static MRAIDPolicy GetMRAIDPolicy()
		{
			return default(MRAIDPolicy);
		}

		public static void SetMRAIDSupportedVersions(string[] versions)
		{
		}

		public static void EnableLogging(bool flag)
		{
		}

		public static void UseGeoLocation(bool isLocationEnabled)
		{
		}

		public static bool IsLocationEnabled()
		{
			return false;
		}

		public static bool IsInitialized()
		{
			return false;
		}

		public static bool IsTestMode()
		{
			return false;
		}

		public static void EnableTesting(bool flag)
		{
		}

		public static void AddCustomAttribute(string withKey, string value)
		{
		}

		public static void RemoveCustomAttribute(string forKey)
		{
		}

		public static void SetAdNetworkInfo(AdNetworkInfo adNetworkInfo)
		{
		}
	}
}

using System;

namespace GGI.Scripts.Internal.iOS
{
	public static class iOSExterns
	{
		public static void SetAdvertiserTrackingEnabled(bool advertiserTrackingEnabled)
		{
		}

		public static void InitStepback(string configStr)
		{
		}

		public static double GetFreeDiskspace()
		{
			return 0.0;
		}

		public static double GetTotalDiskspace()
		{
			return 0.0;
		}

		public static bool HasUserAllowedPushNotifications()
		{
			return false;
		}

		public static bool IsDarkMode()
		{
			return false;
		}

		public static string GetBuildNumber()
		{
			return null;
		}

		public static void ShowSKAdNetworkAd(string adConfigStr)
		{
		}

		public static string GetSKAdNetworkVersion()
		{
			return null;
		}

		public static void UpdateConversionValue(int value)
		{
		}

		public static void RequestAuthorizationTracking(Action<TrackingAuthorizationStatus> status)
		{
		}

		public static void InvokeAuthorizationTrackingCallback(TrackingAuthorizationStatus status)
		{
		}

		public static TrackingAuthorizationStatus GetAuthorizationTrackingStatus()
		{
			return default(TrackingAuthorizationStatus);
		}

		public static bool IsIos145()
		{
			return false;
		}

		public static bool IsIos14()
		{
			return false;
		}

		public static string GetIDFA()
		{
			return null;
		}

		public static void LaunchFakeTrackingNativePopup(string title, string message, string yesButtonText, string noButtonText)
		{
		}

		public static void LaunchFakeTrackingNativePopupV2(int buttonCount, string title, string message, string yesButtonText, string noButtonText)
		{
		}

		public static void GoToTrackingSettings()
		{
		}

		public static void LaunchInAppBrowser(string url)
		{
		}
	}
}

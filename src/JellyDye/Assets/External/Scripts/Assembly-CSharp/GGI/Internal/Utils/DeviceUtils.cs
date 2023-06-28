using System;
using GGI.Scripts.Internal.iOS;

namespace GGI.Internal.Utils
{
	public class DeviceUtils
	{
		public static bool IsTablet()
		{
			return false;
		}

		public static string GetLocale()
		{
			return null;
		}

		public static string GetCarrier()
		{
			return null;
		}

		public static void StartGGIService(string url, string data)
		{
		}

		public static bool IsGJGAppInstalled(string appId)
		{
			return false;
		}

		public static void LaunchAppStore(int id)
		{
		}

		public static double GetFreeDiskspace()
		{
			return 0.0;
		}

		public static void FacebookSetAdvertiserTrackingEnabled(bool value)
		{
		}

		public static double GetTotalDiskspace()
		{
			return 0.0;
		}

		public static bool HasUserAllowedPushNotifications()
		{
			return false;
		}

		public static void RequestAuthorizationTracking(Action<TrackingAuthorizationStatus> status)
		{
		}

		public static TrackingAuthorizationStatus GetAuthorizationTrackingStatus()
		{
			return default(TrackingAuthorizationStatus);
		}

		public static bool IsIos14()
		{
			return false;
		}

		public static bool IsIos145()
		{
			return false;
		}

		public static string GetIDFA()
		{
			return null;
		}

		public static void GoToTrackingSettings()
		{
		}

		public static void LaunchFakeTrackingNativePopup(string title, string message, string yesButtonText, string noButtonText)
		{
		}

		public static void LaunchFakeTrackingNativePopupV2(int buttonCount, string title, string message, string yesButtonText, string noButtonText)
		{
		}

		public static void LaunchInAppBrowser(string url)
		{
		}

		public static bool IsiOSDarkMode()
		{
			return false;
		}

		public static void UpdateConversionValue(int value)
		{
		}
	}
}

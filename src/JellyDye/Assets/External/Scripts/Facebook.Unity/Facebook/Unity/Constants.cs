using System;

namespace Facebook.Unity
{
	internal static class Constants
	{
		private static FacebookUnityPlatform? currentPlatform;

		public static Uri GraphUrl => null;

		public static string GraphApiUserAgent => null;

		public static bool IsMobile => false;

		public static bool IsEditor => false;

		public static bool IsWeb => false;

		public static string UnitySDKUserAgentSuffixLegacy => null;

		public static string UnitySDKUserAgent => null;

		public static bool DebugMode => false;

		public static FacebookUnityPlatform CurrentPlatform => default(FacebookUnityPlatform);

		private static FacebookUnityPlatform GetCurrentPlatform()
		{
			return default(FacebookUnityPlatform);
		}
	}
}

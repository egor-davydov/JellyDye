using System;
using System.Runtime.InteropServices;

namespace Grpc.Core.Internal
{
	internal static class PlatformApis
	{
		private static readonly bool isLinux;

		private static readonly bool isMacOSX;

		private static readonly bool isWindows;

		private static readonly bool isMono;

		private static readonly bool isNet5OrHigher;

		private static readonly bool isNetCore;

		private static readonly string unityApplicationPlatform;

		private static readonly bool isXamarin;

		private static readonly bool isXamarinIOS;

		private static readonly bool isXamarinAndroid;

		public static bool IsLinux => false;

		public static bool IsMacOSX => false;

		public static bool IsWindows => false;

		public static bool IsMono => false;

		public static bool IsUnity => false;

		public static bool IsUnityIOS => false;

		public static bool IsXamarin => false;

		public static bool IsXamarinIOS => false;

		public static bool IsXamarinAndroid => false;

		public static bool IsNet5OrHigher => false;

		public static bool IsNetCore => false;

		public static bool Is64Bit => false;

		static PlatformApis()
		{
		}

		private static string TryGetUnityApplicationPlatform()
		{
			return null;
		}

		[PreserveSig]
		private static extern int uname(IntPtr buf);

		private static string GetUname()
		{
			return null;
		}
	}
}

using System;
using UnityEngine.Scripting;

namespace Firebase.Crashlytics
{
	[Preserve]
	public static class Crashlytics
	{
		[Preserve]
		internal static class PlatformAccessor
		{
			private static ExceptionHandler _exceptionHandler;

			private static Impl _impl;

			private static FirebaseApp _app;

			[Preserve]
			internal static ExceptionHandler ExceptionHandler => null;

			internal static Impl Impl => null;

			[Preserve]
			internal static FirebaseApp App => null;

			static PlatformAccessor()
			{
			}
		}

		public static bool IsCrashlyticsCollectionEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Preserve]
		private static void Initialize()
		{
		}

		public static void Log(string message)
		{
		}

		public static void SetCustomKey(string key, string value)
		{
		}

		public static void SetUserId(string identifier)
		{
		}

		public static void LogException(Exception exception)
		{
		}
	}
}

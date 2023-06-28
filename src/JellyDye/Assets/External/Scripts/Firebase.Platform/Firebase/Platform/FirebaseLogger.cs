using UnityEngine;

namespace Firebase.Platform
{
	internal class FirebaseLogger
	{
		private static MainThreadProperty<bool> incompatibleStackUnwindingEnabled;

		internal static bool CanRedirectNativeLogs => false;

		private static bool IsStackTraceLogTypeIncompatibleWithNativeLogs(StackTraceLogType logType)
		{
			return false;
		}

		private static bool CurrentStackTraceLogTypeIsIncompatibleWithNativeLogs()
		{
			return false;
		}

		internal static void LogMessage(PlatformLogLevel logLevel, string message)
		{
		}
	}
}

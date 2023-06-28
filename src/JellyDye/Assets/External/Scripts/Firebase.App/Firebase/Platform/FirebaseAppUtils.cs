using System;

namespace Firebase.Platform
{
	internal class FirebaseAppUtils : Firebase.Platform.IFirebaseAppUtils
	{
		private static FirebaseAppUtils instance;

		public static FirebaseAppUtils Instance => null;

		public void TranslateDllNotFoundException(Action action)
		{
		}

		public void PollCallbacks()
		{
		}

		public Firebase.Platform.PlatformLogLevel GetLogLevel()
		{
			return default(Firebase.Platform.PlatformLogLevel);
		}
	}
}

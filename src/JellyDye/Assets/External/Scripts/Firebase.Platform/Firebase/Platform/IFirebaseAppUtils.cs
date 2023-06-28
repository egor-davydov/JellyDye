using System;

namespace Firebase.Platform
{
	internal interface IFirebaseAppUtils
	{
		void TranslateDllNotFoundException(Action action);

		void PollCallbacks();

		PlatformLogLevel GetLogLevel();
	}
}

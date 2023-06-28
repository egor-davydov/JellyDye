using System;

namespace Firebase.Crashlytics
{
	internal class AndroidImpl : Impl
	{
		private FirebaseCrashlyticsInternal crashlyticsInternal;

		private readonly FirebaseApp firebaseApp;

		internal AndroidImpl()
		{
		}

		~AndroidImpl()
		{
		}

		private void Dispose()
		{
		}

		public override bool IsSDKInitialized()
		{
			return false;
		}

		private void LogOperationFailedWarningDueToShutdown(string operation)
		{
		}

		private T CallInternalMethod<T>(Func<T> methodCall, string operation, T errorValue = default(T))
		{
			return default(T);
		}

		private void CallInternalMethod(Action methodCall, string operation)
		{
		}

		public override void Log(string message)
		{
		}

		public override void SetCustomKey(string key, string value)
		{
		}

		public override void SetUserId(string identifier)
		{
		}

		public override void LogException(Exception exception)
		{
		}

		public override bool IsCrashlyticsCollectionEnabled()
		{
			return false;
		}

		public override void SetCrashlyticsCollectionEnabled(bool enabled)
		{
		}
	}
}

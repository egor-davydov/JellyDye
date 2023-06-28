using System;
using System.Runtime.InteropServices;

namespace Firebase.Crashlytics
{
	internal class FirebaseCrashlyticsInternal : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal bool IsDisposed => false;

		internal FirebaseCrashlyticsInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FirebaseCrashlyticsInternal obj)
		{
			return default(HandleRef);
		}

		~FirebaseCrashlyticsInternal()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		internal static FirebaseCrashlyticsInternal GetInstance(FirebaseApp app, out InitResult init_result_out)
		{
			init_result_out = default(InitResult);
			return null;
		}

		internal static FirebaseCrashlyticsInternal GetInstance(FirebaseApp app)
		{
			return null;
		}

		public void Log(string message)
		{
		}

		public void SetCustomKey(string key, string value)
		{
		}

		public void SetUserId(string id)
		{
		}

		public void LogException(string name, string reason, StackFrames frames)
		{
		}

		public bool IsCrashlyticsCollectionEnabled()
		{
			return false;
		}

		public void SetCrashlyticsCollectionEnabled(bool enabled)
		{
		}
	}
}

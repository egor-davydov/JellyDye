using System;
using System.Runtime.InteropServices;

namespace Firebase.Crashlytics
{
	public class FirebaseCrashlyticsFrame : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public string library
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string symbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string fileName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string lineNumber
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal FirebaseCrashlyticsFrame(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FirebaseCrashlyticsFrame obj)
		{
			return default(HandleRef);
		}

		~FirebaseCrashlyticsFrame()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public FirebaseCrashlyticsFrame()
		{
		}
	}
}

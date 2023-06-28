using System;
using System.Runtime.InteropServices;

namespace Firebase.Messaging
{
	public sealed class FirebaseMessage : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		private static DateTime UnixEpochUtc;

		internal FirebaseMessage(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		~FirebaseMessage()
		{
		}

		public void Dispose()
		{
		}

		public void Dispose(bool disposing)
		{
		}
	}
}

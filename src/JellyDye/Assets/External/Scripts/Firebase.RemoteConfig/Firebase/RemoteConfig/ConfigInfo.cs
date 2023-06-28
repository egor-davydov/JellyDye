using System;
using System.Runtime.InteropServices;

namespace Firebase.RemoteConfig
{
	public sealed class ConfigInfo : IDisposable
	{
		private HandleRef swigCPtr;

		private bool swigCMemOwn;

		private DateTime UnixEpochUtc;

		public LastFetchStatus LastFetchStatus => default(LastFetchStatus);

		public FetchFailureReason LastFetchFailureReason => default(FetchFailureReason);

		internal ConfigInfo(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		~ConfigInfo()
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

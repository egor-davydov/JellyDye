using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase.RemoteConfig
{
	internal class FirebaseRemoteConfigInternal : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal string InstanceKey => null;

		public FirebaseApp App => null;

		internal FirebaseRemoteConfigInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FirebaseRemoteConfigInternal obj)
		{
			return default(HandleRef);
		}

		~FirebaseRemoteConfigInternal()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		internal void SetSwigCMemOwn(bool ownership)
		{
		}

		public Task<bool> ActivateAsync()
		{
			return null;
		}

		public Task FetchAsync(ulong cacheExpirationInSeconds)
		{
			return null;
		}

		public ConfigInfo GetInfo()
		{
			return null;
		}

		internal static FirebaseRemoteConfigInternal GetInstanceInternal(FirebaseApp app)
		{
			return null;
		}

		internal static void ReleaseReferenceInternal(FirebaseRemoteConfigInternal rc)
		{
		}

		internal ConfigValueInternal GetValueInternal(string key)
		{
			return null;
		}

		internal Task SetDefaultsInternalAsync(Firebase.StringStringMap default_dict)
		{
			return null;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Firebase.Installations
{
	public class FirebaseInstallations : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		private FirebaseApp appProxy;

		private static Dictionary<IntPtr, FirebaseInstallations> installationsByAppCPtr;

		public static FirebaseInstallations DefaultInstance => null;

		internal FirebaseInstallations(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		internal static HandleRef getCPtr(FirebaseInstallations obj)
		{
			return default(HandleRef);
		}

		~FirebaseInstallations()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		private static FirebaseInstallations ProxyFromAppCPtr(IntPtr appCPtr)
		{
			return null;
		}

		private void ThrowIfNull()
		{
		}

		public Task<string> GetIdAsync()
		{
			return null;
		}

		public static FirebaseInstallations GetInstance(FirebaseApp app)
		{
			return null;
		}

		private void OnAppDisposed(object sender, EventArgs eventArgs)
		{
		}

		internal Task<string> GetIdInternalAsync()
		{
			return null;
		}

		internal static FirebaseInstallations GetInstallationsInternal(FirebaseApp app)
		{
			return null;
		}

		internal static void LogHeartbeatInternal(FirebaseApp app)
		{
		}

		internal static void ReleaseReferenceInternal(FirebaseInstallations instance)
		{
		}
	}
}

using System;
using System.Runtime.InteropServices;

namespace Firebase.RemoteConfig
{
	internal class ConfigValueInternal : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		public Firebase.CharVector data => null;

		public ValueSource source => default(ValueSource);

		internal ConfigValueInternal(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		~ConfigValueInternal()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}
	}
}

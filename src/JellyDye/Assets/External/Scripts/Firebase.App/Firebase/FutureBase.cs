using System;
using System.Runtime.InteropServices;

namespace Firebase
{
	internal class FutureBase : IDisposable
	{
		private HandleRef swigCPtr;

		protected bool swigCMemOwn;

		internal FutureBase(IntPtr cPtr, bool cMemoryOwn)
		{
		}

		~FutureBase()
		{
		}

		public void Dispose()
		{
		}

		public virtual void Dispose(bool disposing)
		{
		}

		public FutureStatus status()
		{
			return default(FutureStatus);
		}

		public int error()
		{
			return 0;
		}

		public string error_message()
		{
			return null;
		}
	}
}

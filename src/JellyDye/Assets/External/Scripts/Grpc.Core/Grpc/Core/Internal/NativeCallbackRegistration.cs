using System;
using System.Runtime.InteropServices;

namespace Grpc.Core.Internal
{
	internal class NativeCallbackRegistration : IDisposable
	{
		private readonly GCHandle handle;

		public IntPtr Tag => (IntPtr)0;

		public NativeCallbackRegistration(GCHandle handle)
		{
		}

		public void Dispose()
		{
		}
	}
}

using System;

namespace Grpc.Core.Internal
{
	internal class AuthContextSafeHandle : SafeHandleZeroIsInvalid
	{
		internal struct NativeAuthPropertyIterator
		{
			public IntPtr AuthContext;

			public UIntPtr Index;

			public IntPtr Name;
		}

		private static readonly NativeMethods Native;

		private AuthContextSafeHandle()
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}

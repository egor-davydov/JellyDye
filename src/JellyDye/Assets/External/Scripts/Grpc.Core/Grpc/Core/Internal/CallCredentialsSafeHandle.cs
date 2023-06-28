namespace Grpc.Core.Internal
{
	internal class CallCredentialsSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		private CallCredentialsSafeHandle()
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}

namespace Grpc.Core.Internal
{
	internal class ServerCredentialsSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		private ServerCredentialsSafeHandle()
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}

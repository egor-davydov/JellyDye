namespace Grpc.Core.Internal
{
	internal class CStringSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		private CStringSafeHandle()
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}

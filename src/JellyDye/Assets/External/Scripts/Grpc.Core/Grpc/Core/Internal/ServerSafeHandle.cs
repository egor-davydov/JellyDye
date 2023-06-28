namespace Grpc.Core.Internal
{
	internal sealed class ServerSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		private ServerSafeHandle()
		{
		}

		public void ShutdownAndNotify(BatchCompletionDelegate callback, CompletionQueueSafeHandle completionQueue)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}

		public void CancelAllCalls()
		{
		}
	}
}

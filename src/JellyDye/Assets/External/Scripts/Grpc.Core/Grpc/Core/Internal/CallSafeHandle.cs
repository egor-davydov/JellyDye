using System;

namespace Grpc.Core.Internal
{
	internal class CallSafeHandle : SafeHandleZeroIsInvalid, INativeCall, IDisposable
	{
		public static readonly CallSafeHandle NullInstance;

		private static readonly NativeMethods Native;

		private static readonly BatchCompletionDelegate CompletionHandler_IUnaryResponseClientCallback;

		private static readonly BatchCompletionDelegate CompletionHandler_IReceivedStatusOnClientCallback;

		private static readonly BatchCompletionDelegate CompletionHandler_IReceivedMessageCallback;

		private static readonly BatchCompletionDelegate CompletionHandler_IReceivedResponseHeadersCallback;

		private static readonly BatchCompletionDelegate CompletionHandler_ISendCompletionCallback;

		private static readonly BatchCompletionDelegate CompletionHandler_ISendStatusFromServerCompletionCallback;

		private static readonly BatchCompletionDelegate CompletionHandler_IReceivedCloseOnServerCallback;

		private CompletionQueueSafeHandle completionQueue;

		private CallSafeHandle()
		{
		}

		public void Initialize(CompletionQueueSafeHandle completionQueue)
		{
		}

		public void SetCredentials(CallCredentialsSafeHandle credentials)
		{
		}

		public void StartUnary(IUnaryResponseClientCallback callback, SliceBufferSafeHandle payload, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags)
		{
		}

		public void StartUnary(BatchContextSafeHandle ctx, SliceBufferSafeHandle payload, WriteFlags writeFlags, MetadataArraySafeHandle metadataArray, Grpc.Core.Internal.CallFlags callFlags)
		{
		}

		public void Cancel()
		{
		}

		public void CancelWithStatus(Status status)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}

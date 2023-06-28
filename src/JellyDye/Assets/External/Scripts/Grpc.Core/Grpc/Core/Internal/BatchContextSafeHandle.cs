using System;
using System.Runtime.CompilerServices;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class BatchContextSafeHandle : SafeHandleZeroIsInvalid, IOpCompletionCallback, IPooledObject<BatchContextSafeHandle>, IDisposable, IBufferReader
	{
		private struct CompletionCallbackData
		{
			public BatchCompletionDelegate Callback
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public object State
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			public CompletionCallbackData(BatchCompletionDelegate callback, object state)
			{
			}
		}

		private static readonly NativeMethods Native;

		private static readonly ILogger Logger;

		private Action<BatchContextSafeHandle> returnToPoolAction;

		private CompletionCallbackData completionCallbackData;

		public IntPtr Handle => (IntPtr)0;

		private int? Grpc_002ECore_002EInternal_002EIBufferReader_002ETotalLength => null;

		private BatchContextSafeHandle()
		{
		}

		public static BatchContextSafeHandle Create()
		{
			return null;
		}

		public void SetReturnToPoolAction(Action<BatchContextSafeHandle> returnAction)
		{
		}

		public void SetCompletionCallback(BatchCompletionDelegate callback, object state)
		{
		}

		public Metadata GetReceivedInitialMetadata()
		{
			return null;
		}

		public ClientSideStatus GetReceivedStatusOnClient()
		{
			return default(ClientSideStatus);
		}

		public IBufferReader GetReceivedMessageReader()
		{
			return null;
		}

		public bool GetReceivedCloseOnServerCancelled()
		{
			return false;
		}

		public void Recycle()
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}

		private void Grpc_002ECore_002EInternal_002EIOpCompletionCallback_002EOnComplete(bool success)
		{
		}

		private bool Grpc_002ECore_002EInternal_002EIBufferReader_002ETryGetNextSlice(out Slice slice)
		{
			slice = default(Slice);
			return false;
		}
	}
}

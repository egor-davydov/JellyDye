using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal abstract class AsyncCallBase<TWrite, TRead> : IReceivedMessageCallback, ISendCompletionCallback
	{
		private static readonly ILogger Logger;

		protected static readonly Status DeserializeResponseFailureStatus;

		private readonly Action<TWrite, SerializationContext> serializer;

		private readonly Func<DeserializationContext, TRead> deserializer;

		protected readonly object myLock;

		protected INativeCall call;

		protected bool disposed;

		protected bool started;

		protected bool cancelRequested;

		protected TaskCompletionSource<TRead> streamingReadTcs;

		protected TaskCompletionSource<object> streamingWriteTcs;

		protected bool isStreamingWriteCompletionDelayed;

		protected bool readingDone;

		protected bool halfcloseRequested;

		protected bool finished;

		protected bool initialMetadataSent;

		private static readonly Action<object> CancelCallFromToken;

		protected abstract bool IsClient { get; }

		public AsyncCallBase(Action<TWrite, SerializationContext> serializer, Func<DeserializationContext, TRead> deserializer)
		{
		}

		public void Cancel()
		{
		}

		protected void CancelWithStatus(Status status)
		{
		}

		protected void InitializeInternal(INativeCall call)
		{
		}

		protected bool ReleaseResourcesIfPossible()
		{
			return false;
		}

		protected abstract Exception GetRpcExceptionClientOnly();

		protected void ReleaseResources()
		{
		}

		protected virtual void OnAfterReleaseResourcesLocked()
		{
		}

		protected virtual void OnAfterReleaseResourcesUnlocked()
		{
		}

		protected SliceBufferSafeHandle UnsafeSerialize(TWrite msg, DefaultSerializationContext context)
		{
			return null;
		}

		protected Exception TryDeserialize(IBufferReader reader, out TRead msg)
		{
			msg = default(TRead);
			return null;
		}

		protected void HandleSendFinished(bool success)
		{
		}

		protected void HandleReadFinished(bool success, IBufferReader receivedMessageReader)
		{
		}

		private void Grpc_002ECore_002EInternal_002EISendCompletionCallback_002EOnSendCompletion(bool success)
		{
		}

		private void Grpc_002ECore_002EInternal_002EIReceivedMessageCallback_002EOnReceivedMessage(bool success, IBufferReader receivedMessageReader)
		{
		}

		internal CancellationTokenRegistration RegisterCancellationCallbackForToken(CancellationToken cancellationToken)
		{
			return default(CancellationTokenRegistration);
		}
	}
}

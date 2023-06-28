using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class AsyncCall<TRequest, TResponse> : AsyncCallBase<TRequest, TResponse>, IUnaryResponseClientCallback, IReceivedStatusOnClientCallback, IReceivedResponseHeadersCallback
	{
		private static readonly ILogger Logger;

		private readonly CallInvocationDetails<TRequest, TResponse> details;

		private readonly INativeCall injectedNativeCall;

		private bool registeredWithChannel;

		private CancellationTokenRegistration cancellationTokenRegistration;

		private TaskCompletionSource<TResponse> unaryResponseTcs;

		private TaskCompletionSource<object> streamingResponseCallFinishedTcs;

		private TaskCompletionSource<Metadata> responseHeadersTcs;

		private ClientSideStatus? finishedStatus;

		public Task<Metadata> ResponseHeadersAsync => null;

		protected override bool IsClient => false;

		private IUnaryResponseClientCallback UnaryResponseClientCallback => null;

		public AsyncCall(CallInvocationDetails<TRequest, TResponse> callDetails)
		{
			((AsyncCallBase<, >)(object)this)._002Ector((Action<TWrite, SerializationContext>)null, (Func<DeserializationContext, TRead>)null);
		}

		public TResponse UnaryCall(TRequest msg)
		{
			return default(TResponse);
		}

		public Task<TResponse> UnaryCallAsync(TRequest msg)
		{
			return null;
		}

		public Status GetStatus()
		{
			return default(Status);
		}

		public Metadata GetTrailers()
		{
			return null;
		}

		protected override void OnAfterReleaseResourcesLocked()
		{
		}

		protected override void OnAfterReleaseResourcesUnlocked()
		{
		}

		protected override Exception GetRpcExceptionClientOnly()
		{
			return null;
		}

		private void Initialize(CompletionQueueSafeHandle cq)
		{
		}

		private void OnFailedToStartCallLocked()
		{
		}

		private INativeCall CreateNativeCall(CompletionQueueSafeHandle cq)
		{
			return null;
		}

		private void RegisterCancellationCallback()
		{
		}

		private WriteFlags GetWriteFlagsForCall()
		{
			return default(WriteFlags);
		}

		private void HandleReceivedResponseHeaders(bool success, Metadata responseHeaders)
		{
		}

		private void HandleUnaryResponse(bool success, ClientSideStatus receivedStatus, IBufferReader receivedMessageReader, Metadata responseHeaders)
		{
		}

		private void HandleFinished(bool success, ClientSideStatus receivedStatus)
		{
		}

		private void Grpc_002ECore_002EInternal_002EIUnaryResponseClientCallback_002EOnUnaryResponseClient(bool success, ClientSideStatus receivedStatus, IBufferReader receivedMessageReader, Metadata responseHeaders)
		{
		}

		private void Grpc_002ECore_002EInternal_002EIReceivedStatusOnClientCallback_002EOnReceivedStatusOnClient(bool success, ClientSideStatus receivedStatus)
		{
		}

		private void Grpc_002ECore_002EInternal_002EIReceivedResponseHeadersCallback_002EOnReceivedResponseHeaders(bool success, Metadata responseHeaders)
		{
		}
	}
}

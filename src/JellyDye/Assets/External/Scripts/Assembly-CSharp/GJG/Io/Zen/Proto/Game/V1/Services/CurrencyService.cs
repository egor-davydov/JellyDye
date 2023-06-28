using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.Zen.Proto.Game.V1.Services
{
	public static class CurrencyService
	{
		private static class __Helper_MessageCache<T>
		{
			public static readonly bool IsBufferMessage;
		}

		public abstract class CurrencyServiceBase
		{
			public virtual Task<PendingTransactionsResponse> GetPendingTransactions(GetPendingTransactionsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<SubmitTransactionsResponse> SubmitTransaction(SubmitTransactionRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<AcknowledgeTransactionResponse> AcknowledgeTransaction(AcknowledgeTransactionRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class CurrencyServiceClient : ClientBase<CurrencyServiceClient>
		{
			public CurrencyServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public CurrencyServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected CurrencyServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected CurrencyServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual PendingTransactionsResponse GetPendingTransactions(GetPendingTransactionsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual PendingTransactionsResponse GetPendingTransactions(GetPendingTransactionsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<PendingTransactionsResponse> GetPendingTransactionsAsync(GetPendingTransactionsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<PendingTransactionsResponse> GetPendingTransactionsAsync(GetPendingTransactionsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual SubmitTransactionsResponse SubmitTransaction(SubmitTransactionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual SubmitTransactionsResponse SubmitTransaction(SubmitTransactionRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<SubmitTransactionsResponse> SubmitTransactionAsync(SubmitTransactionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<SubmitTransactionsResponse> SubmitTransactionAsync(SubmitTransactionRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AcknowledgeTransactionResponse AcknowledgeTransaction(AcknowledgeTransactionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AcknowledgeTransactionResponse AcknowledgeTransaction(AcknowledgeTransactionRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<AcknowledgeTransactionResponse> AcknowledgeTransactionAsync(AcknowledgeTransactionRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<AcknowledgeTransactionResponse> AcknowledgeTransactionAsync(AcknowledgeTransactionRequest request, CallOptions options)
			{
				return null;
			}

			protected override CurrencyServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<GetPendingTransactionsRequest> __Marshaller_zen_game_v1_store_services_GetPendingTransactionsRequest;

		private static readonly Marshaller<PendingTransactionsResponse> __Marshaller_zen_game_v1_store_services_PendingTransactionsResponse;

		private static readonly Marshaller<SubmitTransactionRequest> __Marshaller_zen_game_v1_store_services_SubmitTransactionRequest;

		private static readonly Marshaller<SubmitTransactionsResponse> __Marshaller_zen_game_v1_store_services_SubmitTransactionsResponse;

		private static readonly Marshaller<AcknowledgeTransactionRequest> __Marshaller_zen_game_v1_store_services_AcknowledgeTransactionRequest;

		private static readonly Marshaller<AcknowledgeTransactionResponse> __Marshaller_zen_game_v1_store_services_AcknowledgeTransactionResponse;

		private static readonly Method<GetPendingTransactionsRequest, PendingTransactionsResponse> __Method_GetPendingTransactions;

		private static readonly Method<SubmitTransactionRequest, SubmitTransactionsResponse> __Method_SubmitTransaction;

		private static readonly Method<AcknowledgeTransactionRequest, AcknowledgeTransactionResponse> __Method_AcknowledgeTransaction;

		public static ServiceDescriptor Descriptor => null;

		private static void __Helper_SerializeMessage(IMessage message, SerializationContext context)
		{
		}

		private static T __Helper_DeserializeMessage<T>(DeserializationContext context, MessageParser<T> parser) where T : IMessage<T>
		{
			return default(T);
		}

		public static ServerServiceDefinition BindService(CurrencyServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, CurrencyServiceBase serviceImpl)
		{
		}
	}
}

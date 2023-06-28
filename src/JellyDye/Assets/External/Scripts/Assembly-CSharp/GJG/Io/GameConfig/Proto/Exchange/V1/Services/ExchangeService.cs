using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.GameConfig.Proto.Exchange.V1.Services
{
	public static class ExchangeService
	{
		public abstract class ExchangeServiceBase
		{
			public virtual Task<ConvertResponse> Convert(ConvertRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class ExchangeServiceClient : ClientBase<ExchangeServiceClient>
		{
			public ExchangeServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public ExchangeServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected ExchangeServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected ExchangeServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual ConvertResponse Convert(ConvertRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual ConvertResponse Convert(ConvertRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<ConvertResponse> ConvertAsync(ConvertRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<ConvertResponse> ConvertAsync(ConvertRequest request, CallOptions options)
			{
				return null;
			}

			protected override ExchangeServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<ConvertRequest> __Marshaller_gameconfig_v1_exchange_services_ConvertRequest;

		private static readonly Marshaller<ConvertResponse> __Marshaller_gameconfig_v1_exchange_services_ConvertResponse;

		private static readonly Method<ConvertRequest, ConvertResponse> __Method_Convert;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(ExchangeServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, ExchangeServiceBase serviceImpl)
		{
		}
	}
}

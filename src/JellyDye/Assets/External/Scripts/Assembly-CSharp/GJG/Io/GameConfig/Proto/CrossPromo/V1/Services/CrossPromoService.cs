using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.GameConfig.Proto.CrossPromo.V1.Services
{
	public static class CrossPromoService
	{
		public abstract class CrossPromoServiceBase
		{
			public virtual Task<GetAdResponse> GetAd(GetAdRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class CrossPromoServiceClient : ClientBase<CrossPromoServiceClient>
		{
			public CrossPromoServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public CrossPromoServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected CrossPromoServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected CrossPromoServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual GetAdResponse GetAd(GetAdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetAdResponse GetAd(GetAdRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAdResponse> GetAdAsync(GetAdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAdResponse> GetAdAsync(GetAdRequest request, CallOptions options)
			{
				return null;
			}

			protected override CrossPromoServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<GetAdRequest> __Marshaller_gameconfig_v1_crosspromo_services_GetAdRequest;

		private static readonly Marshaller<GetAdResponse> __Marshaller_gameconfig_v1_crosspromo_services_GetAdResponse;

		private static readonly Method<GetAdRequest, GetAdResponse> __Method_GetAd;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(CrossPromoServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, CrossPromoServiceBase serviceImpl)
		{
		}
	}
}

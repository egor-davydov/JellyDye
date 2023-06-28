using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.Iris.App.V1
{
	public static class AppService
	{
		public abstract class AppServiceBase
		{
			public virtual Task<GetAppNamesResponse> GetAppNames(GetAppNamesRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<GetAppResponse> GetApp(GetAppRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<GetAppUANetworkIDsResponse> GetAppUANetworkIDs(GetAppUANetworkIDsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<GetAppMonetizationNetworkIDsResponse> GetAppMonetizationNetworkIDs(GetAppMonetizationNetworkIDsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<GetAppStoreIDsResponse> GetAppStoreIDs(GetAppStoreIDsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<GetAppAdUnitsResponse> GetAppAdUnits(GetAppAdUnitsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<CreateAppResponse> CreateApp(CreateAppRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<PutAppResponse> PutApp(PutAppRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<PutUAIDResponse> PutUAID(PutUAIDRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<PutMonetizationIDResponse> PutMonetizationID(PutMonetizationIDRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<PutAppStoreIDResponse> PutAppStoreID(PutAppStoreIDRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<PutAppAdUnitResponse> PutAppAdUnit(PutAppAdUnitRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class AppServiceClient : ClientBase<AppServiceClient>
		{
			public AppServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public AppServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected AppServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected AppServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual GetAppNamesResponse GetAppNames(GetAppNamesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetAppNamesResponse GetAppNames(GetAppNamesRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppNamesResponse> GetAppNamesAsync(GetAppNamesRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppNamesResponse> GetAppNamesAsync(GetAppNamesRequest request, CallOptions options)
			{
				return null;
			}

			public virtual GetAppResponse GetApp(GetAppRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetAppResponse GetApp(GetAppRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppResponse> GetAppAsync(GetAppRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppResponse> GetAppAsync(GetAppRequest request, CallOptions options)
			{
				return null;
			}

			public virtual GetAppUANetworkIDsResponse GetAppUANetworkIDs(GetAppUANetworkIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetAppUANetworkIDsResponse GetAppUANetworkIDs(GetAppUANetworkIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppUANetworkIDsResponse> GetAppUANetworkIDsAsync(GetAppUANetworkIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppUANetworkIDsResponse> GetAppUANetworkIDsAsync(GetAppUANetworkIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual GetAppMonetizationNetworkIDsResponse GetAppMonetizationNetworkIDs(GetAppMonetizationNetworkIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetAppMonetizationNetworkIDsResponse GetAppMonetizationNetworkIDs(GetAppMonetizationNetworkIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppMonetizationNetworkIDsResponse> GetAppMonetizationNetworkIDsAsync(GetAppMonetizationNetworkIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppMonetizationNetworkIDsResponse> GetAppMonetizationNetworkIDsAsync(GetAppMonetizationNetworkIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual GetAppStoreIDsResponse GetAppStoreIDs(GetAppStoreIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetAppStoreIDsResponse GetAppStoreIDs(GetAppStoreIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppStoreIDsResponse> GetAppStoreIDsAsync(GetAppStoreIDsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppStoreIDsResponse> GetAppStoreIDsAsync(GetAppStoreIDsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual GetAppAdUnitsResponse GetAppAdUnits(GetAppAdUnitsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetAppAdUnitsResponse GetAppAdUnits(GetAppAdUnitsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppAdUnitsResponse> GetAppAdUnitsAsync(GetAppAdUnitsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetAppAdUnitsResponse> GetAppAdUnitsAsync(GetAppAdUnitsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual CreateAppResponse CreateApp(CreateAppRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual CreateAppResponse CreateApp(CreateAppRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<CreateAppResponse> CreateAppAsync(CreateAppRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<CreateAppResponse> CreateAppAsync(CreateAppRequest request, CallOptions options)
			{
				return null;
			}

			public virtual PutAppResponse PutApp(PutAppRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual PutAppResponse PutApp(PutAppRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<PutAppResponse> PutAppAsync(PutAppRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<PutAppResponse> PutAppAsync(PutAppRequest request, CallOptions options)
			{
				return null;
			}

			public virtual PutUAIDResponse PutUAID(PutUAIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual PutUAIDResponse PutUAID(PutUAIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<PutUAIDResponse> PutUAIDAsync(PutUAIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<PutUAIDResponse> PutUAIDAsync(PutUAIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual PutMonetizationIDResponse PutMonetizationID(PutMonetizationIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual PutMonetizationIDResponse PutMonetizationID(PutMonetizationIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<PutMonetizationIDResponse> PutMonetizationIDAsync(PutMonetizationIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<PutMonetizationIDResponse> PutMonetizationIDAsync(PutMonetizationIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual PutAppStoreIDResponse PutAppStoreID(PutAppStoreIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual PutAppStoreIDResponse PutAppStoreID(PutAppStoreIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<PutAppStoreIDResponse> PutAppStoreIDAsync(PutAppStoreIDRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<PutAppStoreIDResponse> PutAppStoreIDAsync(PutAppStoreIDRequest request, CallOptions options)
			{
				return null;
			}

			public virtual PutAppAdUnitResponse PutAppAdUnit(PutAppAdUnitRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual PutAppAdUnitResponse PutAppAdUnit(PutAppAdUnitRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<PutAppAdUnitResponse> PutAppAdUnitAsync(PutAppAdUnitRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<PutAppAdUnitResponse> PutAppAdUnitAsync(PutAppAdUnitRequest request, CallOptions options)
			{
				return null;
			}

			protected override AppServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<GetAppNamesRequest> __Marshaller_app_v1_GetAppNamesRequest;

		private static readonly Marshaller<GetAppNamesResponse> __Marshaller_app_v1_GetAppNamesResponse;

		private static readonly Marshaller<GetAppRequest> __Marshaller_app_v1_GetAppRequest;

		private static readonly Marshaller<GetAppResponse> __Marshaller_app_v1_GetAppResponse;

		private static readonly Marshaller<GetAppUANetworkIDsRequest> __Marshaller_app_v1_GetAppUANetworkIDsRequest;

		private static readonly Marshaller<GetAppUANetworkIDsResponse> __Marshaller_app_v1_GetAppUANetworkIDsResponse;

		private static readonly Marshaller<GetAppMonetizationNetworkIDsRequest> __Marshaller_app_v1_GetAppMonetizationNetworkIDsRequest;

		private static readonly Marshaller<GetAppMonetizationNetworkIDsResponse> __Marshaller_app_v1_GetAppMonetizationNetworkIDsResponse;

		private static readonly Marshaller<GetAppStoreIDsRequest> __Marshaller_app_v1_GetAppStoreIDsRequest;

		private static readonly Marshaller<GetAppStoreIDsResponse> __Marshaller_app_v1_GetAppStoreIDsResponse;

		private static readonly Marshaller<GetAppAdUnitsRequest> __Marshaller_app_v1_GetAppAdUnitsRequest;

		private static readonly Marshaller<GetAppAdUnitsResponse> __Marshaller_app_v1_GetAppAdUnitsResponse;

		private static readonly Marshaller<CreateAppRequest> __Marshaller_app_v1_CreateAppRequest;

		private static readonly Marshaller<CreateAppResponse> __Marshaller_app_v1_CreateAppResponse;

		private static readonly Marshaller<PutAppRequest> __Marshaller_app_v1_PutAppRequest;

		private static readonly Marshaller<PutAppResponse> __Marshaller_app_v1_PutAppResponse;

		private static readonly Marshaller<PutUAIDRequest> __Marshaller_app_v1_PutUAIDRequest;

		private static readonly Marshaller<PutUAIDResponse> __Marshaller_app_v1_PutUAIDResponse;

		private static readonly Marshaller<PutMonetizationIDRequest> __Marshaller_app_v1_PutMonetizationIDRequest;

		private static readonly Marshaller<PutMonetizationIDResponse> __Marshaller_app_v1_PutMonetizationIDResponse;

		private static readonly Marshaller<PutAppStoreIDRequest> __Marshaller_app_v1_PutAppStoreIDRequest;

		private static readonly Marshaller<PutAppStoreIDResponse> __Marshaller_app_v1_PutAppStoreIDResponse;

		private static readonly Marshaller<PutAppAdUnitRequest> __Marshaller_app_v1_PutAppAdUnitRequest;

		private static readonly Marshaller<PutAppAdUnitResponse> __Marshaller_app_v1_PutAppAdUnitResponse;

		private static readonly Method<GetAppNamesRequest, GetAppNamesResponse> __Method_GetAppNames;

		private static readonly Method<GetAppRequest, GetAppResponse> __Method_GetApp;

		private static readonly Method<GetAppUANetworkIDsRequest, GetAppUANetworkIDsResponse> __Method_GetAppUANetworkIDs;

		private static readonly Method<GetAppMonetizationNetworkIDsRequest, GetAppMonetizationNetworkIDsResponse> __Method_GetAppMonetizationNetworkIDs;

		private static readonly Method<GetAppStoreIDsRequest, GetAppStoreIDsResponse> __Method_GetAppStoreIDs;

		private static readonly Method<GetAppAdUnitsRequest, GetAppAdUnitsResponse> __Method_GetAppAdUnits;

		private static readonly Method<CreateAppRequest, CreateAppResponse> __Method_CreateApp;

		private static readonly Method<PutAppRequest, PutAppResponse> __Method_PutApp;

		private static readonly Method<PutUAIDRequest, PutUAIDResponse> __Method_PutUAID;

		private static readonly Method<PutMonetizationIDRequest, PutMonetizationIDResponse> __Method_PutMonetizationID;

		private static readonly Method<PutAppStoreIDRequest, PutAppStoreIDResponse> __Method_PutAppStoreID;

		private static readonly Method<PutAppAdUnitRequest, PutAppAdUnitResponse> __Method_PutAppAdUnit;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(AppServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, AppServiceBase serviceImpl)
		{
		}
	}
}

using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.GameConfig.Proto.Country.V1.Services
{
	public static class CountryService
	{
		public abstract class CountryServiceBase
		{
			public virtual Task<FindMeResponse> FindMe(FindMeRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class CountryServiceClient : ClientBase<CountryServiceClient>
		{
			public CountryServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public CountryServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected CountryServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected CountryServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual FindMeResponse FindMe(FindMeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual FindMeResponse FindMe(FindMeRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<FindMeResponse> FindMeAsync(FindMeRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<FindMeResponse> FindMeAsync(FindMeRequest request, CallOptions options)
			{
				return null;
			}

			protected override CountryServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<FindMeRequest> __Marshaller_gameconfig_v1_country_services_FindMeRequest;

		private static readonly Marshaller<FindMeResponse> __Marshaller_gameconfig_v1_country_services_FindMeResponse;

		private static readonly Method<FindMeRequest, FindMeResponse> __Method_FindMe;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(CountryServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, CountryServiceBase serviceImpl)
		{
		}
	}
}

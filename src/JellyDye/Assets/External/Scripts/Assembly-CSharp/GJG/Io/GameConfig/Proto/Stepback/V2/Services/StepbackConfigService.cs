using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.GameConfig.Proto.Stepback.V2.Services
{
	public static class StepbackConfigService
	{
		public abstract class StepbackConfigServiceBase
		{
			public virtual Task<GetStepbackConfigResponse> GetStepbackConfig(GetStepbackConfigRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class StepbackConfigServiceClient : ClientBase<StepbackConfigServiceClient>
		{
			public StepbackConfigServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public StepbackConfigServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected StepbackConfigServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected StepbackConfigServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual GetStepbackConfigResponse GetStepbackConfig(GetStepbackConfigRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetStepbackConfigResponse GetStepbackConfig(GetStepbackConfigRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetStepbackConfigResponse> GetStepbackConfigAsync(GetStepbackConfigRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetStepbackConfigResponse> GetStepbackConfigAsync(GetStepbackConfigRequest request, CallOptions options)
			{
				return null;
			}

			protected override StepbackConfigServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<GetStepbackConfigRequest> __Marshaller_gameconfig_v2_stepback_services_GetStepbackConfigRequest;

		private static readonly Marshaller<GetStepbackConfigResponse> __Marshaller_gameconfig_v2_stepback_services_GetStepbackConfigResponse;

		private static readonly Method<GetStepbackConfigRequest, GetStepbackConfigResponse> __Method_GetStepbackConfig;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(StepbackConfigServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, StepbackConfigServiceBase serviceImpl)
		{
		}
	}
}

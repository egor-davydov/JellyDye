using System;
using System.Threading;
using System.Threading.Tasks;
using Gjg.Io.GameConfig.Proto.Config.V6.Resources;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.GameConfig.Proto.Config.V6.Services
{
	public static class ConfigService
	{
		public abstract class ConfigServiceBase
		{
			public virtual Task<Gjg.Io.GameConfig.Proto.Config.V6.Resources.Config> Get(GetConfigRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class ConfigServiceClient : ClientBase<ConfigServiceClient>
		{
			public ConfigServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public ConfigServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected ConfigServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected ConfigServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual Gjg.Io.GameConfig.Proto.Config.V6.Resources.Config Get(GetConfigRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual Gjg.Io.GameConfig.Proto.Config.V6.Resources.Config Get(GetConfigRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<Gjg.Io.GameConfig.Proto.Config.V6.Resources.Config> GetAsync(GetConfigRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<Gjg.Io.GameConfig.Proto.Config.V6.Resources.Config> GetAsync(GetConfigRequest request, CallOptions options)
			{
				return null;
			}

			protected override ConfigServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<GetConfigRequest> __Marshaller_gameconfig_v6_config_services_GetConfigRequest;

		private static readonly Marshaller<Gjg.Io.GameConfig.Proto.Config.V6.Resources.Config> __Marshaller_gameconfig_v6_config_resources_Config;

		private static readonly Method<GetConfigRequest, Gjg.Io.GameConfig.Proto.Config.V6.Resources.Config> __Method_Get;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(ConfigServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, ConfigServiceBase serviceImpl)
		{
		}
	}
}

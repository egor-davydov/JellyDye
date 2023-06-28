using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.GameConfig.Proto.PostInit.V2.Services
{
	public static class PostInitService
	{
		public abstract class PostInitServiceBase
		{
			public virtual Task<Nothing> PostInit(PostInitRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<ConversionValue> GetConversionValue(GetConversionValueRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class PostInitServiceClient : ClientBase<PostInitServiceClient>
		{
			public PostInitServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public PostInitServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected PostInitServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected PostInitServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual Nothing PostInit(PostInitRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual Nothing PostInit(PostInitRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<Nothing> PostInitAsync(PostInitRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<Nothing> PostInitAsync(PostInitRequest request, CallOptions options)
			{
				return null;
			}

			public virtual ConversionValue GetConversionValue(GetConversionValueRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual ConversionValue GetConversionValue(GetConversionValueRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<ConversionValue> GetConversionValueAsync(GetConversionValueRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<ConversionValue> GetConversionValueAsync(GetConversionValueRequest request, CallOptions options)
			{
				return null;
			}

			protected override PostInitServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<PostInitRequest> __Marshaller_gameconfig_v2_postinit_services_PostInitRequest;

		private static readonly Marshaller<Nothing> __Marshaller_gameconfig_v2_postinit_services_Nothing;

		private static readonly Marshaller<GetConversionValueRequest> __Marshaller_gameconfig_v2_postinit_services_GetConversionValueRequest;

		private static readonly Marshaller<ConversionValue> __Marshaller_gameconfig_v2_postinit_services_ConversionValue;

		private static readonly Method<PostInitRequest, Nothing> __Method_PostInit;

		private static readonly Method<GetConversionValueRequest, ConversionValue> __Method_GetConversionValue;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(PostInitServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, PostInitServiceBase serviceImpl)
		{
		}
	}
}

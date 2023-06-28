using System;
using System.Threading;
using System.Threading.Tasks;
using Gjg.Io.Iris.V1.Resources;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.Iris.V1.Services
{
	public static class CloudbuildService
	{
		public abstract class CloudbuildServiceBase
		{
			public virtual Task<CloudbuildAppleAccounts> GetAppleAccounts(GetAppleAccountsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<CloudbuildUnityVersion> GetUnityVersions(GetUnityVersionsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<CloudbuildYAMLResponse> GetCloudbuildYAML(GetCloudbuildYAMLRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class CloudbuildServiceClient : ClientBase<CloudbuildServiceClient>
		{
			public CloudbuildServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public CloudbuildServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected CloudbuildServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected CloudbuildServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual CloudbuildAppleAccounts GetAppleAccounts(GetAppleAccountsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual CloudbuildAppleAccounts GetAppleAccounts(GetAppleAccountsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<CloudbuildAppleAccounts> GetAppleAccountsAsync(GetAppleAccountsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<CloudbuildAppleAccounts> GetAppleAccountsAsync(GetAppleAccountsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual CloudbuildUnityVersion GetUnityVersions(GetUnityVersionsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual CloudbuildUnityVersion GetUnityVersions(GetUnityVersionsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<CloudbuildUnityVersion> GetUnityVersionsAsync(GetUnityVersionsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<CloudbuildUnityVersion> GetUnityVersionsAsync(GetUnityVersionsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual CloudbuildYAMLResponse GetCloudbuildYAML(GetCloudbuildYAMLRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual CloudbuildYAMLResponse GetCloudbuildYAML(GetCloudbuildYAMLRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<CloudbuildYAMLResponse> GetCloudbuildYAMLAsync(GetCloudbuildYAMLRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<CloudbuildYAMLResponse> GetCloudbuildYAMLAsync(GetCloudbuildYAMLRequest request, CallOptions options)
			{
				return null;
			}

			protected override CloudbuildServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<GetAppleAccountsRequest> __Marshaller_gjg_io_iris_proto_v1_services_GetAppleAccountsRequest;

		private static readonly Marshaller<CloudbuildAppleAccounts> __Marshaller_gjg_io_iris_proto_v1_resources_CloudbuildAppleAccounts;

		private static readonly Marshaller<GetUnityVersionsRequest> __Marshaller_gjg_io_iris_proto_v1_services_GetUnityVersionsRequest;

		private static readonly Marshaller<CloudbuildUnityVersion> __Marshaller_gjg_io_iris_proto_v1_resources_CloudbuildUnityVersion;

		private static readonly Marshaller<GetCloudbuildYAMLRequest> __Marshaller_gjg_io_iris_proto_v1_services_GetCloudbuildYAMLRequest;

		private static readonly Marshaller<CloudbuildYAMLResponse> __Marshaller_gjg_io_iris_proto_v1_services_CloudbuildYAMLResponse;

		private static readonly Method<GetAppleAccountsRequest, CloudbuildAppleAccounts> __Method_GetAppleAccounts;

		private static readonly Method<GetUnityVersionsRequest, CloudbuildUnityVersion> __Method_GetUnityVersions;

		private static readonly Method<GetCloudbuildYAMLRequest, CloudbuildYAMLResponse> __Method_GetCloudbuildYAML;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(CloudbuildServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, CloudbuildServiceBase serviceImpl)
		{
		}
	}
}

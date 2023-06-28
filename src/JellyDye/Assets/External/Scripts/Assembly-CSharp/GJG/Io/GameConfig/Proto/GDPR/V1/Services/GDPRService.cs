using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.GameConfig.Proto.GDPR.V1.Services
{
	public static class GDPRService
	{
		public abstract class GDPRServiceBase
		{
			public virtual Task<Nothing> GiveConsent(GiveConsentRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class GDPRServiceClient : ClientBase<GDPRServiceClient>
		{
			public GDPRServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public GDPRServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected GDPRServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected GDPRServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual Nothing GiveConsent(GiveConsentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual Nothing GiveConsent(GiveConsentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<Nothing> GiveConsentAsync(GiveConsentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<Nothing> GiveConsentAsync(GiveConsentRequest request, CallOptions options)
			{
				return null;
			}

			protected override GDPRServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<GiveConsentRequest> __Marshaller_gameconfig_v1_gdpr_services_GiveConsentRequest;

		private static readonly Marshaller<Nothing> __Marshaller_gameconfig_v1_gdpr_services_Nothing;

		private static readonly Method<GiveConsentRequest, Nothing> __Method_GiveConsent;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(GDPRServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, GDPRServiceBase serviceImpl)
		{
		}
	}
}

using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.Scio.Client.Event
{
	public static class ClientSegmentService
	{
		public abstract class ClientSegmentServiceBase
		{
			public virtual Task<GetSegmentsResponse> GetSegments(GetSegmentsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<DispatchEventResponse> DispatchEvent(DispatchEventRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<TriggerResponse> Trigger(TriggerRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class ClientSegmentServiceClient : ClientBase<ClientSegmentServiceClient>
		{
			public ClientSegmentServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public ClientSegmentServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected ClientSegmentServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected ClientSegmentServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual GetSegmentsResponse GetSegments(GetSegmentsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual GetSegmentsResponse GetSegments(GetSegmentsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetSegmentsResponse> GetSegmentsAsync(GetSegmentsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<GetSegmentsResponse> GetSegmentsAsync(GetSegmentsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual DispatchEventResponse DispatchEvent(DispatchEventRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual DispatchEventResponse DispatchEvent(DispatchEventRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<DispatchEventResponse> DispatchEventAsync(DispatchEventRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<DispatchEventResponse> DispatchEventAsync(DispatchEventRequest request, CallOptions options)
			{
				return null;
			}

			public virtual TriggerResponse Trigger(TriggerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual TriggerResponse Trigger(TriggerRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<TriggerResponse> TriggerAsync(TriggerRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<TriggerResponse> TriggerAsync(TriggerRequest request, CallOptions options)
			{
				return null;
			}

			protected override ClientSegmentServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<GetSegmentsRequest> __Marshaller_event_v1_GetSegmentsRequest;

		private static readonly Marshaller<GetSegmentsResponse> __Marshaller_event_v1_GetSegmentsResponse;

		private static readonly Marshaller<DispatchEventRequest> __Marshaller_event_v1_DispatchEventRequest;

		private static readonly Marshaller<DispatchEventResponse> __Marshaller_event_v1_DispatchEventResponse;

		private static readonly Marshaller<TriggerRequest> __Marshaller_event_v1_TriggerRequest;

		private static readonly Marshaller<TriggerResponse> __Marshaller_event_v1_TriggerResponse;

		private static readonly Method<GetSegmentsRequest, GetSegmentsResponse> __Method_GetSegments;

		private static readonly Method<DispatchEventRequest, DispatchEventResponse> __Method_DispatchEvent;

		private static readonly Method<TriggerRequest, TriggerResponse> __Method_Trigger;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(ClientSegmentServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, ClientSegmentServiceBase serviceImpl)
		{
		}
	}
}

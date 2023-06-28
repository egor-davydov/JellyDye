using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.Scio.Client.Event
{
	public static class SegmentService
	{
		public abstract class SegmentServiceBase
		{
			public virtual Task<CreateSegmentResponse> CreateSegment(CreateSegmentRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<UpdateSegmentResponse> UpdateSegment(UpdateSegmentRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<ListSegmentsResponse> ListSegments(ListSegmentsRequest request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<ListSegmentsByBundleIdResponse> ListSegmentsByBundleId(ListSegmentsByBundleIdRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class SegmentServiceClient : ClientBase<SegmentServiceClient>
		{
			public SegmentServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public SegmentServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected SegmentServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected SegmentServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual CreateSegmentResponse CreateSegment(CreateSegmentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual CreateSegmentResponse CreateSegment(CreateSegmentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<CreateSegmentResponse> CreateSegmentAsync(CreateSegmentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<CreateSegmentResponse> CreateSegmentAsync(CreateSegmentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual UpdateSegmentResponse UpdateSegment(UpdateSegmentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual UpdateSegmentResponse UpdateSegment(UpdateSegmentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<UpdateSegmentResponse> UpdateSegmentAsync(UpdateSegmentRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<UpdateSegmentResponse> UpdateSegmentAsync(UpdateSegmentRequest request, CallOptions options)
			{
				return null;
			}

			public virtual ListSegmentsResponse ListSegments(ListSegmentsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual ListSegmentsResponse ListSegments(ListSegmentsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<ListSegmentsResponse> ListSegmentsAsync(ListSegmentsRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<ListSegmentsResponse> ListSegmentsAsync(ListSegmentsRequest request, CallOptions options)
			{
				return null;
			}

			public virtual ListSegmentsByBundleIdResponse ListSegmentsByBundleId(ListSegmentsByBundleIdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual ListSegmentsByBundleIdResponse ListSegmentsByBundleId(ListSegmentsByBundleIdRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<ListSegmentsByBundleIdResponse> ListSegmentsByBundleIdAsync(ListSegmentsByBundleIdRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<ListSegmentsByBundleIdResponse> ListSegmentsByBundleIdAsync(ListSegmentsByBundleIdRequest request, CallOptions options)
			{
				return null;
			}

			protected override SegmentServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<CreateSegmentRequest> __Marshaller_event_v1_CreateSegmentRequest;

		private static readonly Marshaller<CreateSegmentResponse> __Marshaller_event_v1_CreateSegmentResponse;

		private static readonly Marshaller<UpdateSegmentRequest> __Marshaller_event_v1_UpdateSegmentRequest;

		private static readonly Marshaller<UpdateSegmentResponse> __Marshaller_event_v1_UpdateSegmentResponse;

		private static readonly Marshaller<ListSegmentsRequest> __Marshaller_event_v1_ListSegmentsRequest;

		private static readonly Marshaller<ListSegmentsResponse> __Marshaller_event_v1_ListSegmentsResponse;

		private static readonly Marshaller<ListSegmentsByBundleIdRequest> __Marshaller_event_v1_ListSegmentsByBundleIdRequest;

		private static readonly Marshaller<ListSegmentsByBundleIdResponse> __Marshaller_event_v1_ListSegmentsByBundleIdResponse;

		private static readonly Method<CreateSegmentRequest, CreateSegmentResponse> __Method_CreateSegment;

		private static readonly Method<UpdateSegmentRequest, UpdateSegmentResponse> __Method_UpdateSegment;

		private static readonly Method<ListSegmentsRequest, ListSegmentsResponse> __Method_ListSegments;

		private static readonly Method<ListSegmentsByBundleIdRequest, ListSegmentsByBundleIdResponse> __Method_ListSegmentsByBundleId;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(SegmentServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, SegmentServiceBase serviceImpl)
		{
		}
	}
}

using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace GGI.Proto
{
	public static class Tracker
	{
		public abstract class TrackerBase
		{
			public virtual Task<EventResponse> Track(Event request, ServerCallContext context)
			{
				return null;
			}

			public virtual Task<EventResponse> TrackAll(Events request, ServerCallContext context)
			{
				return null;
			}
		}

		public class TrackerClient : ClientBase<TrackerClient>
		{
			public TrackerClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public TrackerClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected TrackerClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected TrackerClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual EventResponse Track(Event request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual EventResponse Track(Event request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<EventResponse> TrackAsync(Event request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<EventResponse> TrackAsync(Event request, CallOptions options)
			{
				return null;
			}

			public virtual EventResponse TrackAll(Events request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual EventResponse TrackAll(Events request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<EventResponse> TrackAllAsync(Events request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<EventResponse> TrackAllAsync(Events request, CallOptions options)
			{
				return null;
			}

			protected override TrackerClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<Event> __Marshaller_analyticspb_Event;

		private static readonly Marshaller<EventResponse> __Marshaller_analyticspb_EventResponse;

		private static readonly Marshaller<Events> __Marshaller_analyticspb_Events;

		private static readonly Method<Event, EventResponse> __Method_Track;

		private static readonly Method<Events, EventResponse> __Method_TrackAll;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(TrackerBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, TrackerBase serviceImpl)
		{
		}
	}
}

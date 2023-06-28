using System;
using System.Threading;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;

namespace Gjg.Io.Scio.Client.Event
{
	public static class ScheduleService
	{
		public abstract class ScheduleServiceBase
		{
			public virtual Task<ScheduleResponse> Schedule(ScheduleRequest request, ServerCallContext context)
			{
				return null;
			}
		}

		public class ScheduleServiceClient : ClientBase<ScheduleServiceClient>
		{
			public ScheduleServiceClient(ChannelBase channel)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public ScheduleServiceClient(CallInvoker callInvoker)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected ScheduleServiceClient()
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			protected ScheduleServiceClient(ClientBaseConfiguration configuration)
			{
				((ClientBase<T>)(object)this)._002Ector();
			}

			public virtual ScheduleResponse Schedule(ScheduleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual ScheduleResponse Schedule(ScheduleRequest request, CallOptions options)
			{
				return null;
			}

			public virtual AsyncUnaryCall<ScheduleResponse> ScheduleAsync(ScheduleRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public virtual AsyncUnaryCall<ScheduleResponse> ScheduleAsync(ScheduleRequest request, CallOptions options)
			{
				return null;
			}

			protected override ScheduleServiceClient NewInstance(ClientBaseConfiguration configuration)
			{
				return null;
			}
		}

		private static readonly string __ServiceName;

		private static readonly Marshaller<ScheduleRequest> __Marshaller_event_v1_ScheduleRequest;

		private static readonly Marshaller<ScheduleResponse> __Marshaller_event_v1_ScheduleResponse;

		private static readonly Method<ScheduleRequest, ScheduleResponse> __Method_Schedule;

		public static ServiceDescriptor Descriptor => null;

		public static ServerServiceDefinition BindService(ScheduleServiceBase serviceImpl)
		{
			return null;
		}

		public static void BindService(ServiceBinderBase serviceBinder, ScheduleServiceBase serviceImpl)
		{
		}
	}
}

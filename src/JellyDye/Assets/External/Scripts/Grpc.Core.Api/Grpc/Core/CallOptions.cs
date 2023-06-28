using System;
using System.Threading;
using Grpc.Core.Internal;

namespace Grpc.Core
{
	public struct CallOptions
	{
		private Metadata headers;

		private DateTime? deadline;

		private CancellationToken cancellationToken;

		private WriteOptions writeOptions;

		private ContextPropagationToken propagationToken;

		private CallCredentials credentials;

		private CallFlags flags;

		public Metadata Headers => null;

		public DateTime? Deadline => null;

		public CancellationToken CancellationToken => default(CancellationToken);

		public WriteOptions WriteOptions => null;

		public ContextPropagationToken PropagationToken => null;

		public CallCredentials Credentials => null;

		internal CallFlags Flags => default(CallFlags);

		public CallOptions(Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken), WriteOptions writeOptions = null, ContextPropagationToken propagationToken = null, CallCredentials credentials = null)
		{
		}

		public CallOptions WithHeaders(Metadata headers)
		{
			return default(CallOptions);
		}

		public CallOptions WithDeadline(DateTime deadline)
		{
			return default(CallOptions);
		}

		public CallOptions WithCancellationToken(CancellationToken cancellationToken)
		{
			return default(CallOptions);
		}
	}
}

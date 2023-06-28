using System;
using System.Threading;

namespace Grpc.Core.Internal
{
	internal class ContextPropagationTokenImpl : ContextPropagationToken
	{
		private readonly CallSafeHandle parentCall;

		private readonly DateTime deadline;

		private readonly CancellationToken cancellationToken;

		private readonly ContextPropagationOptions options;

		internal CallSafeHandle ParentCall => null;

		internal DateTime ParentDeadline => default(DateTime);

		internal CancellationToken ParentCancellationToken => default(CancellationToken);

		internal ContextPropagationOptions Options => null;
	}
}

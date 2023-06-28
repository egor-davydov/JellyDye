using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core.Internal;
using Grpc.Core.Logging;

namespace Grpc.Core
{
	public class Channel : ChannelBase
	{
		private static readonly ILogger Logger;

		private readonly object myLock;

		private readonly AtomicCounter activeCallCounter;

		private readonly CancellationTokenSource shutdownTokenSource;

		private readonly GrpcEnvironment environment;

		private readonly CompletionQueueSafeHandle completionQueue;

		private readonly ChannelSafeHandle handle;

		private readonly Dictionary<string, ChannelOption> options;

		private bool shutdownRequested;

		private static readonly BatchCompletionDelegate WatchConnectivityStateHandler;

		public ChannelState State => default(ChannelState);

		internal ChannelSafeHandle Handle => null;

		internal GrpcEnvironment Environment => null;

		internal CompletionQueueSafeHandle CompletionQueue => null;

		public Channel(string target, ChannelCredentials credentials)
			: base(null)
		{
		}

		public Channel(string target, ChannelCredentials credentials, IEnumerable<ChannelOption> options)
			: base(null)
		{
		}

		public Channel(string host, int port, ChannelCredentials credentials)
			: base(null)
		{
		}

		public Channel(string host, int port, ChannelCredentials credentials, IEnumerable<ChannelOption> options)
			: base(null)
		{
		}

		protected override Task ShutdownAsyncCore()
		{
			return null;
		}

		public override CallInvoker CreateCallInvoker()
		{
			return null;
		}

		internal void AddCallReference(object call)
		{
		}

		internal void RemoveCallReference(object call)
		{
		}

		private ChannelState GetConnectivityState(bool tryToConnect)
		{
			return default(ChannelState);
		}

		private static void EnsureUserAgentChannelOption(Dictionary<string, ChannelOption> options)
		{
		}

		private static Dictionary<string, ChannelOption> CreateOptionsDictionary(IEnumerable<ChannelOption> options)
		{
			return null;
		}
	}
}

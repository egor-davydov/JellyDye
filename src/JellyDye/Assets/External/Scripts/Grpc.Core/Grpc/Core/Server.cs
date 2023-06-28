using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core.Internal;
using Grpc.Core.Logging;

namespace Grpc.Core
{
	public class Server
	{
		public class ServiceDefinitionCollection
		{
			private readonly Server server;
		}

		public class ServerPortCollection
		{
			private readonly Server server;
		}

		private const int DefaultRequestCallTokensPerCq = 2000;

		private static readonly ILogger Logger;

		private readonly AtomicCounter activeCallCounter;

		private readonly ServiceDefinitionCollection serviceDefinitions;

		private readonly ServerPortCollection ports;

		private readonly GrpcEnvironment environment;

		private readonly List<ChannelOption> options;

		private readonly ServerSafeHandle handle;

		private readonly object myLock;

		private readonly List<ServerServiceDefinition> serviceDefinitionsList;

		private readonly List<ServerPort> serverPortList;

		private readonly Dictionary<string, IServerCallHandler> callHandlers;

		private readonly TaskCompletionSource<object> shutdownTcs;

		private bool startRequested;

		private bool shutdownRequested;

		private int requestCallTokensPerCq;

		public Task KillAsync()
		{
			return null;
		}

		private Task ShutdownInternalAsync(bool kill)
		{
			return null;
		}

		private Task ShutdownCompleteOrEnvironmentDeadAsync()
		{
			return null;
		}

		private void DisposeHandle()
		{
		}

		private void HandleServerShutdown(bool success, BatchContextSafeHandle ctx, object state)
		{
		}
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Grpc.Core.Internal;
using Grpc.Core.Logging;

namespace Grpc.Core
{
	public class GrpcEnvironment
	{
		private static class ShutdownHooks
		{
			private static object staticLock;

			private static bool hooksRegistered;

			public static void Register()
			{
			}

			private static void HandleShutdown()
			{
			}
		}

		private const int MinDefaultThreadPoolSize = 4;

		private const int DefaultBatchContextPoolSharedCapacity = 10000;

		private const int DefaultBatchContextPoolThreadLocalCapacity = 64;

		private const int DefaultRequestCallContextPoolSharedCapacity = 10000;

		private const int DefaultRequestCallContextPoolThreadLocalCapacity = 64;

		private static object staticLock;

		private static GrpcEnvironment instance;

		private static int refCount;

		private static int? customThreadPoolSize;

		private static int? customCompletionQueueCount;

		private static bool inlineHandlers;

		private static int batchContextPoolSharedCapacity;

		private static int batchContextPoolThreadLocalCapacity;

		private static int requestCallContextPoolSharedCapacity;

		private static int requestCallContextPoolThreadLocalCapacity;

		private static readonly HashSet<Channel> registeredChannels;

		private static readonly HashSet<Server> registeredServers;

		private static readonly AtomicCounter nativeInitCounter;

		private static ILogger logger;

		private readonly IObjectPool<BatchContextSafeHandle> batchContextPool;

		private readonly IObjectPool<RequestCallContextSafeHandle> requestCallContextPool;

		private readonly GrpcThreadPool threadPool;

		private readonly DebugStats debugStats;

		private readonly AtomicCounter cqPickerCounter;

		private bool isShutdown;

		[CompilerGenerated]
		private static EventHandler ShuttingDown;

		public static ILogger Logger => null;

		internal IReadOnlyCollection<CompletionQueueSafeHandle> CompletionQueues => null;

		internal IObjectPool<BatchContextSafeHandle> BatchContextPool => null;

		internal IObjectPool<RequestCallContextSafeHandle> RequestCallContextPool => null;

		internal bool IsAlive => false;

		internal DebugStats DebugStats => null;

		private static bool IsNativeShutdownAllowed => false;

		internal static GrpcEnvironment AddRef()
		{
			return null;
		}

		internal static Task ReleaseAsync()
		{
			return null;
		}

		internal static void RegisterChannel(Channel channel)
		{
		}

		internal static void UnregisterChannel(Channel channel)
		{
		}

		internal static void UnregisterServer(Server server)
		{
		}

		public static Task ShutdownChannelsAsync()
		{
			return null;
		}

		public static Task KillServersAsync()
		{
			return null;
		}

		private GrpcEnvironment()
		{
		}

		internal CompletionQueueSafeHandle PickCompletionQueue()
		{
			return null;
		}

		internal static void GrpcNativeInit()
		{
		}

		internal static void GrpcNativeShutdown()
		{
		}

		private Task ShutdownAsync()
		{
			return null;
		}

		private int GetThreadPoolSizeOrDefault()
		{
			return 0;
		}

		private int GetCompletionQueueCountOrDefault()
		{
			return 0;
		}
	}
}

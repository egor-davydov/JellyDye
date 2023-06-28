using System;
using System.Collections.Generic;
using System.Threading;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class CompletionRegistry
	{
		private class IntPtrComparer : IEqualityComparer<IntPtr>
		{
			public bool Equals(IntPtr x, IntPtr y)
			{
				return false;
			}

			public int GetHashCode(IntPtr obj)
			{
				return 0;
			}
		}

		private static readonly ILogger Logger;

		private readonly GrpcEnvironment environment;

		private readonly Func<BatchContextSafeHandle> batchContextFactory;

		private readonly Func<RequestCallContextSafeHandle> requestCallContextFactory;

		private readonly Dictionary<IntPtr, IOpCompletionCallback> dict;

		private SpinLock spinLock;

		private IntPtr lastRegisteredKey;

		public CompletionRegistry(GrpcEnvironment environment, Func<BatchContextSafeHandle> batchContextFactory, Func<RequestCallContextSafeHandle> requestCallContextFactory)
		{
		}

		public void Register(IntPtr key, IOpCompletionCallback callback)
		{
		}

		public BatchContextSafeHandle RegisterBatchCompletion(BatchCompletionDelegate callback, object state)
		{
			return null;
		}

		public IOpCompletionCallback Extract(IntPtr key)
		{
			return null;
		}
	}
}

using System;

namespace Grpc.Core.Internal
{
	internal class CompletionQueueSafeHandle : SafeHandleZeroIsInvalid
	{
		public struct UsageScope : IDisposable
		{
			private readonly CompletionQueueSafeHandle cq;

			public UsageScope(CompletionQueueSafeHandle cq)
			{
			}

			public void Dispose()
			{
			}
		}

		private static readonly NativeMethods Native;

		private AtomicCounter shutdownRefcount;

		private CompletionRegistry completionRegistry;

		public CompletionRegistry CompletionRegistry => null;

		private CompletionQueueSafeHandle()
		{
		}

		public static CompletionQueueSafeHandle CreateSync()
		{
			return null;
		}

		public static CompletionQueueSafeHandle CreateAsync(CompletionRegistry completionRegistry)
		{
			return null;
		}

		public CompletionQueueEvent Next()
		{
			return default(CompletionQueueEvent);
		}

		public CompletionQueueEvent Pluck(IntPtr tag)
		{
			return default(CompletionQueueEvent);
		}

		public UsageScope NewScope()
		{
			return default(UsageScope);
		}

		public void Shutdown()
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}

		private void DecrementShutdownRefcount()
		{
		}

		private void BeginOp()
		{
		}

		private void EndOp()
		{
		}
	}
}

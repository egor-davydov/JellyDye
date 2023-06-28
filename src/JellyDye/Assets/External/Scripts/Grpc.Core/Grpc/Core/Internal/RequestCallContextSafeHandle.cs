using System;
using System.Runtime.CompilerServices;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class RequestCallContextSafeHandle : SafeHandleZeroIsInvalid, IOpCompletionCallback, IPooledObject<RequestCallContextSafeHandle>, IDisposable
	{
		private static readonly NativeMethods Native;

		private static readonly ILogger Logger;

		private Action<RequestCallContextSafeHandle> returnToPoolAction;

		public RequestCallCompletionDelegate CompletionCallback
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		private RequestCallContextSafeHandle()
		{
		}

		public static RequestCallContextSafeHandle Create()
		{
			return null;
		}

		public void SetReturnToPoolAction(Action<RequestCallContextSafeHandle> returnAction)
		{
		}

		public void Recycle()
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}

		private void Grpc_002ECore_002EInternal_002EIOpCompletionCallback_002EOnComplete(bool success)
		{
		}
	}
}

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	[StructLayout(3)]
	public struct UniTaskCompletionSourceCore<TResult>
	{
		private TResult result;

		private object error;

		private short version;

		private bool hasUnhandledError;

		private int completedCount;

		private Action<object> continuation;

		private object continuationState;

		[DebuggerHidden]
		public short Version => 0;

		[DebuggerHidden]
		public void Reset()
		{
		}

		private void ReportUnhandledError()
		{
		}

		internal void MarkHandled()
		{
		}

		[DebuggerHidden]
		public bool TrySetResult(TResult result)
		{
			return false;
		}

		[DebuggerHidden]
		public bool TrySetException(Exception error)
		{
			return false;
		}

		[DebuggerHidden]
		public bool TrySetCanceled(CancellationToken cancellationToken = default(CancellationToken))
		{
			return false;
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public UniTaskStatus GetStatus(short token)
		{
			return default(UniTaskStatus);
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public UniTaskStatus UnsafeGetStatus()
		{
			return default(UniTaskStatus);
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public TResult GetResult(short token)
		{
			return default(TResult);
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void OnCompleted(Action<object> continuation, object state, short token)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		private void ValidateToken(short token)
		{
		}
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public class UniTaskCompletionSource : IUniTaskSource, IPromise, IResolvePromise, IRejectPromise, ICancelPromise
	{
		private CancellationToken cancellationToken;

		private ExceptionHolder exception;

		private object gate;

		private Action<object> singleContinuation;

		private object singleState;

		private List<(Action<object>, object)> secondaryContinuationList;

		private int intStatus;

		private bool handled;

		public UniTask Task
		{
			[DebuggerHidden]
			get
			{
				return default(UniTask);
			}
		}

		[DebuggerHidden]
		internal void MarkHandled()
		{
		}

		[DebuggerHidden]
		public bool TrySetResult()
		{
			return false;
		}

		[DebuggerHidden]
		public bool TrySetCanceled(CancellationToken cancellationToken = default(CancellationToken))
		{
			return false;
		}

		[DebuggerHidden]
		public bool TrySetException(Exception exception)
		{
			return false;
		}

		[DebuggerHidden]
		public void GetResult(short token)
		{
		}

		[DebuggerHidden]
		public UniTaskStatus GetStatus(short token)
		{
			return default(UniTaskStatus);
		}

		[DebuggerHidden]
		public UniTaskStatus UnsafeGetStatus()
		{
			return default(UniTaskStatus);
		}

		[DebuggerHidden]
		public void OnCompleted(Action<object> continuation, object state, short token)
		{
		}

		[DebuggerHidden]
		private bool TrySignalCompletion(UniTaskStatus status)
		{
			return false;
		}
	}
	public class UniTaskCompletionSource<T> : IUniTaskSource<T>, IUniTaskSource, IPromise<T>, IResolvePromise<T>, IRejectPromise, ICancelPromise
	{
		private CancellationToken cancellationToken;

		private T result;

		private ExceptionHolder exception;

		private object gate;

		private Action<object> singleContinuation;

		private object singleState;

		private List<(Action<object>, object)> secondaryContinuationList;

		private int intStatus;

		private bool handled;

		public UniTask<T> Task
		{
			[DebuggerHidden]
			get
			{
				return default(UniTask<T>);
			}
		}

		[DebuggerHidden]
		internal void MarkHandled()
		{
		}

		[DebuggerHidden]
		public bool TrySetResult(T result)
		{
			return false;
		}

		[DebuggerHidden]
		public bool TrySetCanceled(CancellationToken cancellationToken = default(CancellationToken))
		{
			return false;
		}

		[DebuggerHidden]
		public bool TrySetException(Exception exception)
		{
			return false;
		}

		[DebuggerHidden]
		public T GetResult(short token)
		{
			return default(T);
		}

		[DebuggerHidden]
		private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
		{
		}

		[DebuggerHidden]
		public UniTaskStatus GetStatus(short token)
		{
			return default(UniTaskStatus);
		}

		[DebuggerHidden]
		public UniTaskStatus UnsafeGetStatus()
		{
			return default(UniTaskStatus);
		}

		[DebuggerHidden]
		public void OnCompleted(Action<object> continuation, object state, short token)
		{
		}

		[DebuggerHidden]
		private bool TrySignalCompletion(UniTaskStatus status)
		{
			return false;
		}
	}
}

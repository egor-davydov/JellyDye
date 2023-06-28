using System;
using System.Diagnostics;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public class AutoResetUniTaskCompletionSource : IUniTaskSource, ITaskPoolNode<AutoResetUniTaskCompletionSource>, IPromise, IResolvePromise, IRejectPromise, ICancelPromise
	{
		private static TaskPool<AutoResetUniTaskCompletionSource> pool;

		private AutoResetUniTaskCompletionSource nextNode;

		private UniTaskCompletionSourceCore<AsyncUnit> core;

		public unsafe ref AutoResetUniTaskCompletionSource NextNode => ref *(AutoResetUniTaskCompletionSource*)null;

		public UniTask Task
		{
			[DebuggerHidden]
			get
			{
				return default(UniTask);
			}
		}

		static AutoResetUniTaskCompletionSource()
		{
		}

		private AutoResetUniTaskCompletionSource()
		{
		}

		[DebuggerHidden]
		public static AutoResetUniTaskCompletionSource Create()
		{
			return null;
		}

		[DebuggerHidden]
		public static AutoResetUniTaskCompletionSource CreateFromCanceled(CancellationToken cancellationToken, out short token)
		{
			token = default(short);
			return null;
		}

		[DebuggerHidden]
		public static AutoResetUniTaskCompletionSource CreateFromException(Exception exception, out short token)
		{
			token = default(short);
			return null;
		}

		[DebuggerHidden]
		public static AutoResetUniTaskCompletionSource CreateCompleted(out short token)
		{
			token = default(short);
			return null;
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
		private bool TryReturn()
		{
			return false;
		}
	}
	public class AutoResetUniTaskCompletionSource<T> : IUniTaskSource<T>, IUniTaskSource, ITaskPoolNode<AutoResetUniTaskCompletionSource<T>>, IPromise<T>, IResolvePromise<T>, IRejectPromise, ICancelPromise
	{
		private static TaskPool<AutoResetUniTaskCompletionSource<T>> pool;

		private AutoResetUniTaskCompletionSource<T> nextNode;

		private UniTaskCompletionSourceCore<T> core;

		public unsafe ref AutoResetUniTaskCompletionSource<T> NextNode => ref *(AutoResetUniTaskCompletionSource<T>*)null;

		public UniTask<T> Task
		{
			[DebuggerHidden]
			get
			{
				return default(UniTask<T>);
			}
		}

		static AutoResetUniTaskCompletionSource()
		{
		}

		private AutoResetUniTaskCompletionSource()
		{
		}

		[DebuggerHidden]
		public static AutoResetUniTaskCompletionSource<T> Create()
		{
			return null;
		}

		[DebuggerHidden]
		public static AutoResetUniTaskCompletionSource<T> CreateFromCanceled(CancellationToken cancellationToken, out short token)
		{
			token = default(short);
			return null;
		}

		[DebuggerHidden]
		public static AutoResetUniTaskCompletionSource<T> CreateFromException(Exception exception, out short token)
		{
			token = default(short);
			return null;
		}

		[DebuggerHidden]
		public static AutoResetUniTaskCompletionSource<T> CreateFromResult(T result, out short token)
		{
			token = default(short);
			return null;
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
		private bool TryReturn()
		{
			return false;
		}
	}
}

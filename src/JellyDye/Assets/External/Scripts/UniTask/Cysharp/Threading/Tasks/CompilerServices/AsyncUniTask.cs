using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks.CompilerServices
{
	internal sealed class AsyncUniTask<TStateMachine> : IStateMachineRunnerPromise, IUniTaskSource, ITaskPoolNode<AsyncUniTask<TStateMachine>> where TStateMachine : IAsyncStateMachine
	{
		private static TaskPool<AsyncUniTask<TStateMachine>> pool;

		private readonly Action returnDelegate;

		private TStateMachine stateMachine;

		private UniTaskCompletionSourceCore<AsyncUnit> core;

		private AsyncUniTask<TStateMachine> nextNode;

		public Action MoveNext
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public unsafe ref AsyncUniTask<TStateMachine> NextNode => ref *(AsyncUniTask<TStateMachine>*)null;

		public UniTask Task
		{
			[DebuggerHidden]
			get
			{
				return default(UniTask);
			}
		}

		private AsyncUniTask()
		{
		}

		public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunnerPromise runnerPromiseFieldRef)
		{
		}

		static AsyncUniTask()
		{
		}

		private void Return()
		{
		}

		private bool TryReturn()
		{
			return false;
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		private void Run()
		{
		}

		[DebuggerHidden]
		public void SetResult()
		{
		}

		[DebuggerHidden]
		public void SetException(Exception exception)
		{
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
	}
	internal sealed class AsyncUniTask<TStateMachine, T> : IStateMachineRunnerPromise<T>, IUniTaskSource<T>, IUniTaskSource, ITaskPoolNode<AsyncUniTask<TStateMachine, T>> where TStateMachine : IAsyncStateMachine
	{
		private static TaskPool<AsyncUniTask<TStateMachine, T>> pool;

		private readonly Action returnDelegate;

		private TStateMachine stateMachine;

		private UniTaskCompletionSourceCore<T> core;

		private AsyncUniTask<TStateMachine, T> nextNode;

		public Action MoveNext
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public unsafe ref AsyncUniTask<TStateMachine, T> NextNode => ref *(AsyncUniTask<TStateMachine, T>*)null;

		public UniTask<T> Task
		{
			[DebuggerHidden]
			get
			{
				return default(UniTask<T>);
			}
		}

		private AsyncUniTask()
		{
		}

		public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunnerPromise<T> runnerPromiseFieldRef)
		{
		}

		static AsyncUniTask()
		{
		}

		private void Return()
		{
		}

		private bool TryReturn()
		{
			return false;
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		private void Run()
		{
		}

		[DebuggerHidden]
		public void SetResult(T result)
		{
		}

		[DebuggerHidden]
		public void SetException(Exception exception)
		{
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
	}
}

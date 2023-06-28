using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Cysharp.Threading.Tasks.CompilerServices
{
	[StructLayout(3)]
	public struct AsyncUniTaskMethodBuilder
	{
		private IStateMachineRunnerPromise runnerPromise;

		private Exception ex;

		public UniTask Task
		{
			[MethodImpl(256)]
			[DebuggerHidden]
			get
			{
				return default(UniTask);
			}
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public static AsyncUniTaskMethodBuilder Create()
		{
			return default(AsyncUniTaskMethodBuilder);
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetException(Exception exception)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetResult()
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}
	[StructLayout(3)]
	public struct AsyncUniTaskMethodBuilder<T>
	{
		private IStateMachineRunnerPromise<T> runnerPromise;

		private Exception ex;

		private T result;

		public UniTask<T> Task
		{
			[MethodImpl(256)]
			[DebuggerHidden]
			get
			{
				return default(UniTask<T>);
			}
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public static AsyncUniTaskMethodBuilder<T> Create()
		{
			return default(AsyncUniTaskMethodBuilder<T>);
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetException(Exception exception)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void SetResult(T result)
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		[SecuritySafeCritical]
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
		{
		}

		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}
}

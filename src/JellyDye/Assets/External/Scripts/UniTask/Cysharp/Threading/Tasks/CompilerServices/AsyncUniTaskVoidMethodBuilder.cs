using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Cysharp.Threading.Tasks.CompilerServices
{
	[StructLayout(3)]
	public struct AsyncUniTaskVoidMethodBuilder
	{
		private IStateMachineRunner runner;

		public UniTaskVoid Task
		{
			[MethodImpl(256)]
			[DebuggerHidden]
			get
			{
				return default(UniTaskVoid);
			}
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		public static AsyncUniTaskVoidMethodBuilder Create()
		{
			return default(AsyncUniTaskVoidMethodBuilder);
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

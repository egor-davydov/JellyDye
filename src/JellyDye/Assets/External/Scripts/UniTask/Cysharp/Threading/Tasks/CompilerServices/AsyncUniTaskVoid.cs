using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks.CompilerServices
{
	internal sealed class AsyncUniTaskVoid<TStateMachine> : IStateMachineRunner, ITaskPoolNode<AsyncUniTaskVoid<TStateMachine>>, IUniTaskSource where TStateMachine : IAsyncStateMachine
	{
		private static TaskPool<AsyncUniTaskVoid<TStateMachine>> pool;

		private TStateMachine stateMachine;

		private AsyncUniTaskVoid<TStateMachine> nextNode;

		public Action ReturnAction
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Action MoveNext
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public unsafe ref AsyncUniTaskVoid<TStateMachine> NextNode => ref *(AsyncUniTaskVoid<TStateMachine>*)null;

		public static void SetStateMachine(ref TStateMachine stateMachine, ref IStateMachineRunner runnerFieldRef)
		{
		}

		static AsyncUniTaskVoid()
		{
		}

		public void Return()
		{
		}

		[MethodImpl(256)]
		[DebuggerHidden]
		private void Run()
		{
		}

		private UniTaskStatus Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetStatus(short token)
		{
			return default(UniTaskStatus);
		}

		private UniTaskStatus Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EUnsafeGetStatus()
		{
			return default(UniTaskStatus);
		}

		private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EOnCompleted(Action<object> continuation, object state, short token)
		{
		}

		private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
		{
		}
	}
}

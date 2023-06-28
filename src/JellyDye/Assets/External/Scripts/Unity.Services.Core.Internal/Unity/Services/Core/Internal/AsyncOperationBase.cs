using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Services.Core.Internal
{
	internal abstract class AsyncOperationBase : CustomYieldInstruction, IAsyncOperation, IEnumerator, INotifyCompletion
	{
		private Action<IAsyncOperation> m_CompletedCallback;

		public override bool keepWaiting => false;

		public abstract bool IsCompleted { get; }

		public bool IsDone => false;

		public abstract AsyncOperationStatus Status { get; }

		public abstract Exception Exception { get; }

		public event Action<IAsyncOperation> Completed
		{
			add
			{
			}
			remove
			{
			}
		}

		public abstract void GetResult();

		public abstract AsyncOperationBase GetAwaiter();

		protected void DidComplete()
		{
		}

		public virtual void OnCompleted(Action continuation)
		{
		}
	}
}

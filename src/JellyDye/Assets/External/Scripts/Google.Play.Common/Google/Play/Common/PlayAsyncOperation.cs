using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Google.Play.Common
{
	public abstract class PlayAsyncOperation<TResult, TError> : CustomYieldInstruction
	{
		public bool IsDone
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public abstract bool IsSuccessful { get; }

		public TError Error
		{
			[CompilerGenerated]
			get
			{
				return default(TError);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public override bool keepWaiting => false;

		public virtual event Action<PlayAsyncOperation<TResult, TError>> Completed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public TResult GetResult()
		{
			return default(TResult);
		}

		protected void InvokeCompletedEvent()
		{
		}

		protected abstract TResult GetResultImpl();
	}
}

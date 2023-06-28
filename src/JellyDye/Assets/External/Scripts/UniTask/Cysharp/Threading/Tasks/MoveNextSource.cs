using System;

namespace Cysharp.Threading.Tasks
{
	public abstract class MoveNextSource : IUniTaskSource<bool>, IUniTaskSource
	{
		protected UniTaskCompletionSourceCore<bool> completionSource;

		public bool GetResult(short token)
		{
			return false;
		}

		public UniTaskStatus GetStatus(short token)
		{
			return default(UniTaskStatus);
		}

		public void OnCompleted(Action<object> continuation, object state, short token)
		{
		}

		public UniTaskStatus UnsafeGetStatus()
		{
			return default(UniTaskStatus);
		}

		private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
		{
		}

		protected bool TryGetResult<T>(UniTask<T>.Awaiter awaiter, out T result)
		{
			result = default(T);
			return false;
		}

		protected bool TryGetResult(UniTask.Awaiter awaiter)
		{
			return false;
		}
	}
}

using System;

namespace Google.Play.Common.Internal
{
	public abstract class PlayAsyncOperationImpl<TResult, TError> : PlayAsyncOperation<TResult, TError>
	{
		private TResult _result;

		public override event Action<PlayAsyncOperation<TResult, TError>> Completed
		{
			add
			{
			}
			remove
			{
			}
		}

		public void SetResult(TResult result)
		{
		}

		public void SetError(TError errorCode)
		{
		}

		protected override TResult GetResultImpl()
		{
			return default(TResult);
		}

		protected PlayAsyncOperationImpl()
		{
			((PlayAsyncOperation<, >)(object)this)._002Ector();
		}
	}
}

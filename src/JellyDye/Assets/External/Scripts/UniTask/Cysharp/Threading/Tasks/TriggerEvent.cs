using System;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public struct TriggerEvent<T>
	{
		private ITriggerHandler<T> head;

		private ITriggerHandler<T> iteratingHead;

		private bool preserveRemoveSelf;

		private ITriggerHandler<T> iteratingNode;

		private void LogError(Exception ex)
		{
		}

		public void SetResult(T value)
		{
		}

		public void SetCanceled(CancellationToken cancellationToken)
		{
		}

		public void SetCompleted()
		{
		}

		public void SetError(Exception exception)
		{
		}

		public void Add(ITriggerHandler<T> handler)
		{
		}

		public void Remove(ITriggerHandler<T> handler)
		{
		}
	}
}

using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncAnimatorMoveTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnAnimatorMove()
		{
		}

		public IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler()
		{
			return null;
		}

		public IAsyncOnAnimatorMoveHandler GetOnAnimatorMoveAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnAnimatorMoveAsync()
		{
			return default(UniTask);
		}

		public UniTask OnAnimatorMoveAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncAnimatorMoveTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

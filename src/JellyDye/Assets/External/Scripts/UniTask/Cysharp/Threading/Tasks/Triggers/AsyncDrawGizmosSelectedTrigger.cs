using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncDrawGizmosSelectedTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnDrawGizmosSelected()
		{
		}

		public IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler()
		{
			return null;
		}

		public IAsyncOnDrawGizmosSelectedHandler GetOnDrawGizmosSelectedAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnDrawGizmosSelectedAsync()
		{
			return default(UniTask);
		}

		public UniTask OnDrawGizmosSelectedAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncDrawGizmosSelectedTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

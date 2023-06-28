using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncDrawGizmosTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnDrawGizmos()
		{
		}

		public IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler()
		{
			return null;
		}

		public IAsyncOnDrawGizmosHandler GetOnDrawGizmosAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnDrawGizmosAsync()
		{
			return default(UniTask);
		}

		public UniTask OnDrawGizmosAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncDrawGizmosTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

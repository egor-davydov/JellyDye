using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncBeforeTransformParentChangedTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnBeforeTransformParentChanged()
		{
		}

		public IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler()
		{
			return null;
		}

		public IAsyncOnBeforeTransformParentChangedHandler GetOnBeforeTransformParentChangedAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnBeforeTransformParentChangedAsync()
		{
			return default(UniTask);
		}

		public UniTask OnBeforeTransformParentChangedAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncBeforeTransformParentChangedTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

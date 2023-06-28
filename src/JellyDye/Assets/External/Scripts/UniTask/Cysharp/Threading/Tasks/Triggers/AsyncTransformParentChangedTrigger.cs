using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncTransformParentChangedTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnTransformParentChanged()
		{
		}

		public IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler()
		{
			return null;
		}

		public IAsyncOnTransformParentChangedHandler GetOnTransformParentChangedAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnTransformParentChangedAsync()
		{
			return default(UniTask);
		}

		public UniTask OnTransformParentChangedAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncTransformParentChangedTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

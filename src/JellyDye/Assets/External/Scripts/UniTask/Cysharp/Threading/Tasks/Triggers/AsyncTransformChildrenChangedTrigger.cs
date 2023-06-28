using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncTransformChildrenChangedTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnTransformChildrenChanged()
		{
		}

		public IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler()
		{
			return null;
		}

		public IAsyncOnTransformChildrenChangedHandler GetOnTransformChildrenChangedAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnTransformChildrenChangedAsync()
		{
			return default(UniTask);
		}

		public UniTask OnTransformChildrenChangedAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncTransformChildrenChangedTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncRectTransformDimensionsChangeTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnRectTransformDimensionsChange()
		{
		}

		public IAsyncOnRectTransformDimensionsChangeHandler GetOnRectTransformDimensionsChangeAsyncHandler()
		{
			return null;
		}

		public IAsyncOnRectTransformDimensionsChangeHandler GetOnRectTransformDimensionsChangeAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnRectTransformDimensionsChangeAsync()
		{
			return default(UniTask);
		}

		public UniTask OnRectTransformDimensionsChangeAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncRectTransformDimensionsChangeTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

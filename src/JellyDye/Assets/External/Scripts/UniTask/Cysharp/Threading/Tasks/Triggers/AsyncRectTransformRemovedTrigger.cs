using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncRectTransformRemovedTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnRectTransformRemoved()
		{
		}

		public IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler()
		{
			return null;
		}

		public IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnRectTransformRemovedAsync()
		{
			return default(UniTask);
		}

		public UniTask OnRectTransformRemovedAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncRectTransformRemovedTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

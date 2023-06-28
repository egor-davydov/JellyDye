using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncRenderObjectTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnRenderObject()
		{
		}

		public IAsyncOnRenderObjectHandler GetOnRenderObjectAsyncHandler()
		{
			return null;
		}

		public IAsyncOnRenderObjectHandler GetOnRenderObjectAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnRenderObjectAsync()
		{
			return default(UniTask);
		}

		public UniTask OnRenderObjectAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncRenderObjectTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

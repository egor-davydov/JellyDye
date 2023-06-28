using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncBecameInvisibleTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnBecameInvisible()
		{
		}

		public IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler()
		{
			return null;
		}

		public IAsyncOnBecameInvisibleHandler GetOnBecameInvisibleAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnBecameInvisibleAsync()
		{
			return default(UniTask);
		}

		public UniTask OnBecameInvisibleAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncBecameInvisibleTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

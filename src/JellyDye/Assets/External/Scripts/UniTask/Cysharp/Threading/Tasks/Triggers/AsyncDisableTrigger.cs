using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncDisableTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnDisable()
		{
		}

		public IAsyncOnDisableHandler GetOnDisableAsyncHandler()
		{
			return null;
		}

		public IAsyncOnDisableHandler GetOnDisableAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnDisableAsync()
		{
			return default(UniTask);
		}

		public UniTask OnDisableAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncDisableTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

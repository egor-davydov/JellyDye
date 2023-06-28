using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncEnableTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnEnable()
		{
		}

		public IAsyncOnEnableHandler GetOnEnableAsyncHandler()
		{
			return null;
		}

		public IAsyncOnEnableHandler GetOnEnableAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnEnableAsync()
		{
			return default(UniTask);
		}

		public UniTask OnEnableAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncEnableTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncPreCullTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnPreCull()
		{
		}

		public IAsyncOnPreCullHandler GetOnPreCullAsyncHandler()
		{
			return null;
		}

		public IAsyncOnPreCullHandler GetOnPreCullAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnPreCullAsync()
		{
			return default(UniTask);
		}

		public UniTask OnPreCullAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncPreCullTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

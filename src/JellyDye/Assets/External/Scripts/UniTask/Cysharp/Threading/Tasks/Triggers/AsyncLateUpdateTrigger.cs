using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncLateUpdateTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void LateUpdate()
		{
		}

		public IAsyncLateUpdateHandler GetLateUpdateAsyncHandler()
		{
			return null;
		}

		public IAsyncLateUpdateHandler GetLateUpdateAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask LateUpdateAsync()
		{
			return default(UniTask);
		}

		public UniTask LateUpdateAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncLateUpdateTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

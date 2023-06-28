using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncFixedUpdateTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void FixedUpdate()
		{
		}

		public IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler()
		{
			return null;
		}

		public IAsyncFixedUpdateHandler GetFixedUpdateAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask FixedUpdateAsync()
		{
			return default(UniTask);
		}

		public UniTask FixedUpdateAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncFixedUpdateTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncUpdateTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void Update()
		{
		}

		public IAsyncUpdateHandler GetUpdateAsyncHandler()
		{
			return null;
		}

		public IAsyncUpdateHandler GetUpdateAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask UpdateAsync()
		{
			return default(UniTask);
		}

		public UniTask UpdateAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncUpdateTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

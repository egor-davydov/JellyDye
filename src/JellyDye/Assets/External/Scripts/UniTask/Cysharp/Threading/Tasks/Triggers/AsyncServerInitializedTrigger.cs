using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncServerInitializedTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnServerInitialized()
		{
		}

		public IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler()
		{
			return null;
		}

		public IAsyncOnServerInitializedHandler GetOnServerInitializedAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnServerInitializedAsync()
		{
			return default(UniTask);
		}

		public UniTask OnServerInitializedAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncServerInitializedTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

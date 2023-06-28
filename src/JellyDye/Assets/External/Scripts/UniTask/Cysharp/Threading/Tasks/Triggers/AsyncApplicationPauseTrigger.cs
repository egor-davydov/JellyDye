using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncApplicationPauseTrigger : AsyncTriggerBase<bool>
	{
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		public IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler()
		{
			return null;
		}

		public IAsyncOnApplicationPauseHandler GetOnApplicationPauseAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<bool> OnApplicationPauseAsync()
		{
			return default(UniTask<bool>);
		}

		public UniTask<bool> OnApplicationPauseAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		public AsyncApplicationPauseTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

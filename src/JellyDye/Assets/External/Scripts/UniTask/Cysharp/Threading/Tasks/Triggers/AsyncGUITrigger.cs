using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncGUITrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnGUI()
		{
		}

		public IAsyncOnGUIHandler GetOnGUIAsyncHandler()
		{
			return null;
		}

		public IAsyncOnGUIHandler GetOnGUIAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnGUIAsync()
		{
			return default(UniTask);
		}

		public UniTask OnGUIAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncGUITrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncApplicationFocusTrigger : AsyncTriggerBase<bool>
	{
		private void OnApplicationFocus(bool hasFocus)
		{
		}

		public IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler()
		{
			return null;
		}

		public IAsyncOnApplicationFocusHandler GetOnApplicationFocusAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<bool> OnApplicationFocusAsync()
		{
			return default(UniTask<bool>);
		}

		public UniTask<bool> OnApplicationFocusAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<bool>);
		}

		public AsyncApplicationFocusTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

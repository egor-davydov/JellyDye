using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncApplicationQuitTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnApplicationQuit()
		{
		}

		public IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler()
		{
			return null;
		}

		public IAsyncOnApplicationQuitHandler GetOnApplicationQuitAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnApplicationQuitAsync()
		{
			return default(UniTask);
		}

		public UniTask OnApplicationQuitAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncApplicationQuitTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

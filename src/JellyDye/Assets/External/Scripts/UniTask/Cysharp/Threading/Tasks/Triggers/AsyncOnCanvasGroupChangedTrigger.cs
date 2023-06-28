using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncOnCanvasGroupChangedTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnCanvasGroupChanged()
		{
		}

		public IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler()
		{
			return null;
		}

		public IAsyncOnCanvasGroupChangedHandler GetOnCanvasGroupChangedAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnCanvasGroupChangedAsync()
		{
			return default(UniTask);
		}

		public UniTask OnCanvasGroupChangedAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncOnCanvasGroupChangedTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

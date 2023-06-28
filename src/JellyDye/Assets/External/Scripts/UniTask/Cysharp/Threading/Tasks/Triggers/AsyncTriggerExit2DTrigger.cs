using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncTriggerExit2DTrigger : AsyncTriggerBase<Collider2D>
	{
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		public IAsyncOnTriggerExit2DHandler GetOnTriggerExit2DAsyncHandler()
		{
			return null;
		}

		public IAsyncOnTriggerExit2DHandler GetOnTriggerExit2DAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<Collider2D> OnTriggerExit2DAsync()
		{
			return default(UniTask<Collider2D>);
		}

		public UniTask<Collider2D> OnTriggerExit2DAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<Collider2D>);
		}

		public AsyncTriggerExit2DTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

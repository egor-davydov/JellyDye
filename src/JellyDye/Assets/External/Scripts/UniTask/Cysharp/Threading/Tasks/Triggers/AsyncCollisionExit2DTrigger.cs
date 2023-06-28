using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncCollisionExit2DTrigger : AsyncTriggerBase<Collision2D>
	{
		private void OnCollisionExit2D(Collision2D coll)
		{
		}

		public IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler()
		{
			return null;
		}

		public IAsyncOnCollisionExit2DHandler GetOnCollisionExit2DAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<Collision2D> OnCollisionExit2DAsync()
		{
			return default(UniTask<Collision2D>);
		}

		public UniTask<Collision2D> OnCollisionExit2DAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<Collision2D>);
		}

		public AsyncCollisionExit2DTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncCollisionStay2DTrigger : AsyncTriggerBase<Collision2D>
	{
		private void OnCollisionStay2D(Collision2D coll)
		{
		}

		public IAsyncOnCollisionStay2DHandler GetOnCollisionStay2DAsyncHandler()
		{
			return null;
		}

		public IAsyncOnCollisionStay2DHandler GetOnCollisionStay2DAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<Collision2D> OnCollisionStay2DAsync()
		{
			return default(UniTask<Collision2D>);
		}

		public UniTask<Collision2D> OnCollisionStay2DAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<Collision2D>);
		}

		public AsyncCollisionStay2DTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

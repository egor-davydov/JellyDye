using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncCollisionEnter2DTrigger : AsyncTriggerBase<Collision2D>
	{
		private void OnCollisionEnter2D(Collision2D coll)
		{
		}

		public IAsyncOnCollisionEnter2DHandler GetOnCollisionEnter2DAsyncHandler()
		{
			return null;
		}

		public IAsyncOnCollisionEnter2DHandler GetOnCollisionEnter2DAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<Collision2D> OnCollisionEnter2DAsync()
		{
			return default(UniTask<Collision2D>);
		}

		public UniTask<Collision2D> OnCollisionEnter2DAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<Collision2D>);
		}

		public AsyncCollisionEnter2DTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

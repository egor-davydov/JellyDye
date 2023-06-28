using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncTriggerEnter2DTrigger : AsyncTriggerBase<Collider2D>
	{
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		public IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler()
		{
			return null;
		}

		public IAsyncOnTriggerEnter2DHandler GetOnTriggerEnter2DAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<Collider2D> OnTriggerEnter2DAsync()
		{
			return default(UniTask<Collider2D>);
		}

		public UniTask<Collider2D> OnTriggerEnter2DAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<Collider2D>);
		}

		public AsyncTriggerEnter2DTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

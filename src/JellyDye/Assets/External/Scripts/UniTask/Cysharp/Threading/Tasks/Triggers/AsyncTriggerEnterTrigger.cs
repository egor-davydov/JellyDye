using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncTriggerEnterTrigger : AsyncTriggerBase<Collider>
	{
		private void OnTriggerEnter(Collider other)
		{
		}

		public IAsyncOnTriggerEnterHandler GetOnTriggerEnterAsyncHandler()
		{
			return null;
		}

		public IAsyncOnTriggerEnterHandler GetOnTriggerEnterAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<Collider> OnTriggerEnterAsync()
		{
			return default(UniTask<Collider>);
		}

		public UniTask<Collider> OnTriggerEnterAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<Collider>);
		}

		public AsyncTriggerEnterTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

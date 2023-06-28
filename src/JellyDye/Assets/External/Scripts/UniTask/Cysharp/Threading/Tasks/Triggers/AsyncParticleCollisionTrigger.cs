using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncParticleCollisionTrigger : AsyncTriggerBase<GameObject>
	{
		private void OnParticleCollision(GameObject other)
		{
		}

		public IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler()
		{
			return null;
		}

		public IAsyncOnParticleCollisionHandler GetOnParticleCollisionAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<GameObject> OnParticleCollisionAsync()
		{
			return default(UniTask<GameObject>);
		}

		public UniTask<GameObject> OnParticleCollisionAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<GameObject>);
		}

		public AsyncParticleCollisionTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

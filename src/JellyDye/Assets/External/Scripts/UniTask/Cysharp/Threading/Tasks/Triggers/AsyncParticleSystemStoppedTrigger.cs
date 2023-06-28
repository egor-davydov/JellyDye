using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncParticleSystemStoppedTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnParticleSystemStopped()
		{
		}

		public IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler()
		{
			return null;
		}

		public IAsyncOnParticleSystemStoppedHandler GetOnParticleSystemStoppedAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnParticleSystemStoppedAsync()
		{
			return default(UniTask);
		}

		public UniTask OnParticleSystemStoppedAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncParticleSystemStoppedTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

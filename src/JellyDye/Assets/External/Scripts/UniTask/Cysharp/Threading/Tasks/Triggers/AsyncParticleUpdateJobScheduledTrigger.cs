using System.Threading;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncParticleUpdateJobScheduledTrigger : AsyncTriggerBase<ParticleSystemJobData>
	{
		private void OnParticleUpdateJobScheduled(ParticleSystemJobData particles)
		{
		}

		public IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler()
		{
			return null;
		}

		public IAsyncOnParticleUpdateJobScheduledHandler GetOnParticleUpdateJobScheduledAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync()
		{
			return default(UniTask<ParticleSystemJobData>);
		}

		public UniTask<ParticleSystemJobData> OnParticleUpdateJobScheduledAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<ParticleSystemJobData>);
		}

		public AsyncParticleUpdateJobScheduledTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

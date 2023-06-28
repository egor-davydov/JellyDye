using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncParticleTriggerTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnParticleTrigger()
		{
		}

		public IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler()
		{
			return null;
		}

		public IAsyncOnParticleTriggerHandler GetOnParticleTriggerAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnParticleTriggerAsync()
		{
			return default(UniTask);
		}

		public UniTask OnParticleTriggerAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncParticleTriggerTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

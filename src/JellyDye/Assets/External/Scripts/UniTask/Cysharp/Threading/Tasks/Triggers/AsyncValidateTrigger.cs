using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncValidateTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnValidate()
		{
		}

		public IAsyncOnValidateHandler GetOnValidateAsyncHandler()
		{
			return null;
		}

		public IAsyncOnValidateHandler GetOnValidateAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnValidateAsync()
		{
			return default(UniTask);
		}

		public UniTask OnValidateAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncValidateTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

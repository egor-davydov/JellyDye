using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncAnimatorIKTrigger : AsyncTriggerBase<int>
	{
		private void OnAnimatorIK(int layerIndex)
		{
		}

		public IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler()
		{
			return null;
		}

		public IAsyncOnAnimatorIKHandler GetOnAnimatorIKAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<int> OnAnimatorIKAsync()
		{
			return default(UniTask<int>);
		}

		public UniTask<int> OnAnimatorIKAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<int>);
		}

		public AsyncAnimatorIKTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

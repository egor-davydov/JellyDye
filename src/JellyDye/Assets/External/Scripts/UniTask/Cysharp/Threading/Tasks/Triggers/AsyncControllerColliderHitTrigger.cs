using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncControllerColliderHitTrigger : AsyncTriggerBase<ControllerColliderHit>
	{
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		public IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler()
		{
			return null;
		}

		public IAsyncOnControllerColliderHitHandler GetOnControllerColliderHitAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<ControllerColliderHit> OnControllerColliderHitAsync()
		{
			return default(UniTask<ControllerColliderHit>);
		}

		public UniTask<ControllerColliderHit> OnControllerColliderHitAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<ControllerColliderHit>);
		}

		public AsyncControllerColliderHitTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

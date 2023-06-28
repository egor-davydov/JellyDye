using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncUpdateSelectedTrigger : AsyncTriggerBase<BaseEventData>, IUpdateSelectedHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EIUpdateSelectedHandler_002EOnUpdateSelected(BaseEventData eventData)
		{
		}

		public IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler()
		{
			return null;
		}

		public IAsyncOnUpdateSelectedHandler GetOnUpdateSelectedAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<BaseEventData> OnUpdateSelectedAsync()
		{
			return default(UniTask<BaseEventData>);
		}

		public UniTask<BaseEventData> OnUpdateSelectedAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}

		public AsyncUpdateSelectedTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

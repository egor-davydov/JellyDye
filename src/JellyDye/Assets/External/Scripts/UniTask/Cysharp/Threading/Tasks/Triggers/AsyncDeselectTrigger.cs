using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncDeselectTrigger : AsyncTriggerBase<BaseEventData>, IDeselectHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EIDeselectHandler_002EOnDeselect(BaseEventData eventData)
		{
		}

		public IAsyncOnDeselectHandler GetOnDeselectAsyncHandler()
		{
			return null;
		}

		public IAsyncOnDeselectHandler GetOnDeselectAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<BaseEventData> OnDeselectAsync()
		{
			return default(UniTask<BaseEventData>);
		}

		public UniTask<BaseEventData> OnDeselectAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}

		public AsyncDeselectTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

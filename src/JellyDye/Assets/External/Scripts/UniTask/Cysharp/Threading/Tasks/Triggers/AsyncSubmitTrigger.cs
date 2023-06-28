using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncSubmitTrigger : AsyncTriggerBase<BaseEventData>, ISubmitHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EISubmitHandler_002EOnSubmit(BaseEventData eventData)
		{
		}

		public IAsyncOnSubmitHandler GetOnSubmitAsyncHandler()
		{
			return null;
		}

		public IAsyncOnSubmitHandler GetOnSubmitAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<BaseEventData> OnSubmitAsync()
		{
			return default(UniTask<BaseEventData>);
		}

		public UniTask<BaseEventData> OnSubmitAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}

		public AsyncSubmitTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncPointerEnterTrigger : AsyncTriggerBase<PointerEventData>, IPointerEnterHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EIPointerEnterHandler_002EOnPointerEnter(PointerEventData eventData)
		{
		}

		public IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler()
		{
			return null;
		}

		public IAsyncOnPointerEnterHandler GetOnPointerEnterAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<PointerEventData> OnPointerEnterAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		public UniTask<PointerEventData> OnPointerEnterAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		public AsyncPointerEnterTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

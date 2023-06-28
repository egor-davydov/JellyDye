using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncDragTrigger : AsyncTriggerBase<PointerEventData>, IDragHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EIDragHandler_002EOnDrag(PointerEventData eventData)
		{
		}

		public IAsyncOnDragHandler GetOnDragAsyncHandler()
		{
			return null;
		}

		public IAsyncOnDragHandler GetOnDragAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<PointerEventData> OnDragAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		public UniTask<PointerEventData> OnDragAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		public AsyncDragTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

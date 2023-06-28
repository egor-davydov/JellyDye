using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncBeginDragTrigger : AsyncTriggerBase<PointerEventData>, IBeginDragHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EIBeginDragHandler_002EOnBeginDrag(PointerEventData eventData)
		{
		}

		public IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler()
		{
			return null;
		}

		public IAsyncOnBeginDragHandler GetOnBeginDragAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<PointerEventData> OnBeginDragAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		public UniTask<PointerEventData> OnBeginDragAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		public AsyncBeginDragTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

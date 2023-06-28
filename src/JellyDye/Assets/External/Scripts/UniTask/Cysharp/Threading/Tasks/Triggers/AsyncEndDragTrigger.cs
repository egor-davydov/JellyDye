using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncEndDragTrigger : AsyncTriggerBase<PointerEventData>, IEndDragHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EIEndDragHandler_002EOnEndDrag(PointerEventData eventData)
		{
		}

		public IAsyncOnEndDragHandler GetOnEndDragAsyncHandler()
		{
			return null;
		}

		public IAsyncOnEndDragHandler GetOnEndDragAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<PointerEventData> OnEndDragAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		public UniTask<PointerEventData> OnEndDragAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		public AsyncEndDragTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncScrollTrigger : AsyncTriggerBase<PointerEventData>, IScrollHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EIScrollHandler_002EOnScroll(PointerEventData eventData)
		{
		}

		public IAsyncOnScrollHandler GetOnScrollAsyncHandler()
		{
			return null;
		}

		public IAsyncOnScrollHandler GetOnScrollAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<PointerEventData> OnScrollAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		public UniTask<PointerEventData> OnScrollAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		public AsyncScrollTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

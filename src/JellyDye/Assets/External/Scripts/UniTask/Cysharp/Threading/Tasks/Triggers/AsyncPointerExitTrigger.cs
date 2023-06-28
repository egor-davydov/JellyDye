using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncPointerExitTrigger : AsyncTriggerBase<PointerEventData>, IPointerExitHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EIPointerExitHandler_002EOnPointerExit(PointerEventData eventData)
		{
		}

		public IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler()
		{
			return null;
		}

		public IAsyncOnPointerExitHandler GetOnPointerExitAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<PointerEventData> OnPointerExitAsync()
		{
			return default(UniTask<PointerEventData>);
		}

		public UniTask<PointerEventData> OnPointerExitAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<PointerEventData>);
		}

		public AsyncPointerExitTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

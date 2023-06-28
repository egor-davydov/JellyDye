using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncSelectTrigger : AsyncTriggerBase<BaseEventData>, ISelectHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EISelectHandler_002EOnSelect(BaseEventData eventData)
		{
		}

		public IAsyncOnSelectHandler GetOnSelectAsyncHandler()
		{
			return null;
		}

		public IAsyncOnSelectHandler GetOnSelectAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<BaseEventData> OnSelectAsync()
		{
			return default(UniTask<BaseEventData>);
		}

		public UniTask<BaseEventData> OnSelectAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}

		public AsyncSelectTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

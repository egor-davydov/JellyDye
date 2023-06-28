using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncCancelTrigger : AsyncTriggerBase<BaseEventData>, ICancelHandler, IEventSystemHandler
	{
		private void UnityEngine_002EEventSystems_002EICancelHandler_002EOnCancel(BaseEventData eventData)
		{
		}

		public IAsyncOnCancelHandler GetOnCancelAsyncHandler()
		{
			return null;
		}

		public IAsyncOnCancelHandler GetOnCancelAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<BaseEventData> OnCancelAsync()
		{
			return default(UniTask<BaseEventData>);
		}

		public UniTask<BaseEventData> OnCancelAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<BaseEventData>);
		}

		public AsyncCancelTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

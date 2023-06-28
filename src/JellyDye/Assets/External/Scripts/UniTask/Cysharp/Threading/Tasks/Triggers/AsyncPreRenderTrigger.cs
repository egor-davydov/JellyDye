using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncPreRenderTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void OnPreRender()
		{
		}

		public IAsyncOnPreRenderHandler GetOnPreRenderAsyncHandler()
		{
			return null;
		}

		public IAsyncOnPreRenderHandler GetOnPreRenderAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask OnPreRenderAsync()
		{
			return default(UniTask);
		}

		public UniTask OnPreRenderAsync(CancellationToken cancellationToken)
		{
			return default(UniTask);
		}

		public AsyncPreRenderTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncAudioFilterReadTrigger : AsyncTriggerBase<(float[], int)>
	{
		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		public IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler()
		{
			return null;
		}

		public IAsyncOnAudioFilterReadHandler GetOnAudioFilterReadAsyncHandler(CancellationToken cancellationToken)
		{
			return null;
		}

		public UniTask<(float[], int)> OnAudioFilterReadAsync()
		{
			return default(UniTask<(float[], int)>);
		}

		public UniTask<(float[], int)> OnAudioFilterReadAsync(CancellationToken cancellationToken)
		{
			return default(UniTask<(float[], int)>);
		}

		public AsyncAudioFilterReadTrigger()
		{
			((AsyncTriggerBase<>)(object)this)._002Ector();
		}
	}
}

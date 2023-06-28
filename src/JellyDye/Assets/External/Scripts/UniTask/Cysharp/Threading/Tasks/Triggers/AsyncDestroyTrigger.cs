using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncDestroyTrigger : MonoBehaviour
	{
		private class AwakeMonitor : IPlayerLoopItem
		{
			private readonly AsyncDestroyTrigger trigger;

			public AwakeMonitor(AsyncDestroyTrigger trigger)
			{
			}

			public bool MoveNext()
			{
				return false;
			}
		}

		private bool awakeCalled;

		private bool called;

		private CancellationTokenSource cancellationTokenSource;

		public CancellationToken CancellationToken => default(CancellationToken);

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public UniTask OnDestroyAsync()
		{
			return default(UniTask);
		}
	}
}

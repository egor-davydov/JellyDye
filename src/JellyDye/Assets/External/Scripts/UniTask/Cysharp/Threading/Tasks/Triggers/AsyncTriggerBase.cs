using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	public abstract class AsyncTriggerBase<T> : MonoBehaviour, IUniTaskAsyncEnumerable<T>
	{
		private sealed class AsyncTriggerEnumerator : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable, ITriggerHandler<T>
		{
			private static Action<object> cancellationCallback;

			private readonly AsyncTriggerBase<T> parent;

			private CancellationToken cancellationToken;

			private CancellationTokenRegistration registration;

			private bool called;

			private bool isDisposed;

			public T Current
			{
				[CompilerGenerated]
				get
				{
					return default(T);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			private ITriggerHandler<T> Cysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002EPrev
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			private ITriggerHandler<T> Cysharp_002EThreading_002ETasks_002EITriggerHandler_003CT_003E_002ENext
			{
				[CompilerGenerated]
				get
				{
					return null;
				}
				[CompilerGenerated]
				set
				{
				}
			}

			public AsyncTriggerEnumerator(AsyncTriggerBase<T> parent, CancellationToken cancellationToken)
			{
			}

			public void OnCanceled(CancellationToken cancellationToken = default(CancellationToken))
			{
			}

			public void OnNext(T value)
			{
			}

			public void OnCompleted()
			{
			}

			public void OnError(Exception ex)
			{
			}

			private static void CancellationCallback(object state)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private class AwakeMonitor : IPlayerLoopItem
		{
			private readonly AsyncTriggerBase<T> trigger;

			public AwakeMonitor(AsyncTriggerBase<T> trigger)
			{
			}

			public bool MoveNext()
			{
				return false;
			}
		}

		private TriggerEvent<T> triggerEvent;

		protected internal bool calledAwake;

		protected internal bool calledDestroy;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		internal void AddHandler(ITriggerHandler<T> handler)
		{
		}

		internal void RemoveHandler(ITriggerHandler<T> handler)
		{
		}

		protected void RaiseEvent(T value)
		{
		}

		public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks
{
	public class ReadOnlyAsyncReactiveProperty<T> : IReadOnlyAsyncReactiveProperty<T>, IUniTaskAsyncEnumerable<T>, IDisposable
	{
		private sealed class WaitAsyncSource : IUniTaskSource<T>, IUniTaskSource, ITriggerHandler<T>, ITaskPoolNode<WaitAsyncSource>
		{
			private static Action<object> cancellationCallback;

			private static TaskPool<WaitAsyncSource> pool;

			private WaitAsyncSource nextNode;

			private ReadOnlyAsyncReactiveProperty<T> parent;

			private CancellationToken cancellationToken;

			private CancellationTokenRegistration cancellationTokenRegistration;

			private UniTaskCompletionSourceCore<T> core;

			private unsafe ref WaitAsyncSource Cysharp_002EThreading_002ETasks_002EITaskPoolNode_003CCysharp_002EThreading_002ETasks_002EReadOnlyAsyncReactiveProperty_003CT_003E_002EWaitAsyncSource_003E_002ENextNode => ref *(WaitAsyncSource*)null;

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

			static WaitAsyncSource()
			{
			}

			private WaitAsyncSource()
			{
			}

			public static IUniTaskSource<T> Create(ReadOnlyAsyncReactiveProperty<T> parent, CancellationToken cancellationToken, out short token)
			{
				token = default(short);
				return null;
			}

			private bool TryReturn()
			{
				return false;
			}

			private static void CancellationCallback(object state)
			{
			}

			public T GetResult(short token)
			{
				return default(T);
			}

			private void Cysharp_002EThreading_002ETasks_002EIUniTaskSource_002EGetResult(short token)
			{
			}

			public void OnCompleted(Action<object> continuation, object state, short token)
			{
			}

			public UniTaskStatus GetStatus(short token)
			{
				return default(UniTaskStatus);
			}

			public UniTaskStatus UnsafeGetStatus()
			{
				return default(UniTaskStatus);
			}

			public void OnCanceled(CancellationToken cancellationToken)
			{
			}

			public void OnCompleted()
			{
			}

			public void OnError(Exception ex)
			{
			}

			public void OnNext(T value)
			{
			}
		}

		private sealed class WithoutCurrentEnumerable : IUniTaskAsyncEnumerable<T>
		{
			private readonly ReadOnlyAsyncReactiveProperty<T> parent;

			public WithoutCurrentEnumerable(ReadOnlyAsyncReactiveProperty<T> parent)
			{
			}

			public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}
		}

		private sealed class Enumerator : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable, ITriggerHandler<T>
		{
			private static Action<object> cancellationCallback;

			private readonly ReadOnlyAsyncReactiveProperty<T> parent;

			private readonly CancellationToken cancellationToken;

			private readonly CancellationTokenRegistration cancellationTokenRegistration;

			private T value;

			private bool isDisposed;

			private bool firstCall;

			public T Current => default(T);

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

			public Enumerator(ReadOnlyAsyncReactiveProperty<T> parent, CancellationToken cancellationToken, bool publishCurrentValue)
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

			public void OnNext(T value)
			{
			}

			public void OnCanceled(CancellationToken cancellationToken)
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
		}

		private TriggerEvent<T> triggerEvent;

		private T latestValue;

		private IUniTaskAsyncEnumerator<T> enumerator;

		private static bool isValueType;

		public T Value => default(T);

		public ReadOnlyAsyncReactiveProperty(T initialValue, IUniTaskAsyncEnumerable<T> source, CancellationToken cancellationToken)
		{
		}

		public ReadOnlyAsyncReactiveProperty(IUniTaskAsyncEnumerable<T> source, CancellationToken cancellationToken)
		{
		}

		private UniTaskVoid ConsumeEnumerator(IUniTaskAsyncEnumerable<T> source, CancellationToken cancellationToken)
		{
			return default(UniTaskVoid);
		}

		public IUniTaskAsyncEnumerable<T> WithoutCurrent()
		{
			return null;
		}

		public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken)
		{
			return null;
		}

		public void Dispose()
		{
		}

		public static implicit operator T(ReadOnlyAsyncReactiveProperty<T> value)
		{
			return default(T);
		}

		public override string ToString()
		{
			return null;
		}

		public UniTask<T> WaitAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return default(UniTask<T>);
		}

		static ReadOnlyAsyncReactiveProperty()
		{
		}
	}
}

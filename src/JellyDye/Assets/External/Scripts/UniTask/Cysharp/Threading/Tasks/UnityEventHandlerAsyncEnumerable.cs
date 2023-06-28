using System;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Events;

namespace Cysharp.Threading.Tasks
{
	public class UnityEventHandlerAsyncEnumerable : IUniTaskAsyncEnumerable<AsyncUnit>
	{
		private class UnityEventHandlerAsyncEnumerator : MoveNextSource, IUniTaskAsyncEnumerator<AsyncUnit>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> cancel1;

			private static readonly Action<object> cancel2;

			private readonly UnityEvent unityEvent;

			private CancellationToken cancellationToken1;

			private CancellationToken cancellationToken2;

			private UnityAction unityAction;

			private CancellationTokenRegistration registration1;

			private CancellationTokenRegistration registration2;

			private bool isDisposed;

			public AsyncUnit Current => default(AsyncUnit);

			public UnityEventHandlerAsyncEnumerator(UnityEvent unityEvent, CancellationToken cancellationToken1, CancellationToken cancellationToken2)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private void Invoke()
			{
			}

			private static void OnCanceled1(object state)
			{
			}

			private static void OnCanceled2(object state)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly UnityEvent unityEvent;

		private readonly CancellationToken cancellationToken1;

		public UnityEventHandlerAsyncEnumerable(UnityEvent unityEvent, CancellationToken cancellationToken)
		{
		}

		public IUniTaskAsyncEnumerator<AsyncUnit> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	public class UnityEventHandlerAsyncEnumerable<T> : IUniTaskAsyncEnumerable<T>
	{
		private class UnityEventHandlerAsyncEnumerator : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> cancel1;

			private static readonly Action<object> cancel2;

			private readonly UnityEvent<T> unityEvent;

			private CancellationToken cancellationToken1;

			private CancellationToken cancellationToken2;

			private UnityAction<T> unityAction;

			private CancellationTokenRegistration registration1;

			private CancellationTokenRegistration registration2;

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

			public UnityEventHandlerAsyncEnumerator(UnityEvent<T> unityEvent, CancellationToken cancellationToken1, CancellationToken cancellationToken2)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private void Invoke(T value)
			{
			}

			private static void OnCanceled1(object state)
			{
			}

			private static void OnCanceled2(object state)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly UnityEvent<T> unityEvent;

		private readonly CancellationToken cancellationToken1;

		public UnityEventHandlerAsyncEnumerable(UnityEvent<T> unityEvent, CancellationToken cancellationToken)
		{
		}

		public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

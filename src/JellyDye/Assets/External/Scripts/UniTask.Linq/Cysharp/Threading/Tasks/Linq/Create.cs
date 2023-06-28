using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class Create<T> : IUniTaskAsyncEnumerable<T>
	{
		private sealed class _Create : MoveNextSource, IUniTaskAsyncEnumerator<T>, IUniTaskAsyncDisposable
		{
			private readonly Func<IAsyncWriter<T>, CancellationToken, UniTask> create;

			private readonly CancellationToken cancellationToken;

			private int state;

			private AsyncWriter writer;

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

			public _Create(Func<IAsyncWriter<T>, CancellationToken, UniTask> create, CancellationToken cancellationToken)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private void MoveNext()
			{
			}

			private UniTaskVoid RunWriterTask(UniTask task)
			{
				return default(UniTaskVoid);
			}

			public void SetResult(T value)
			{
			}
		}

		private sealed class AsyncWriter : IUniTaskSource, IAsyncWriter<T>
		{
			private readonly _Create enumerator;

			private UniTaskCompletionSourceCore<AsyncUnit> core;

			public AsyncWriter(_Create enumerator)
			{
			}

			public void GetResult(short token)
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

			public void OnCompleted(Action<object> continuation, object state, short token)
			{
			}

			public UniTask YieldAsync(T value)
			{
				return default(UniTask);
			}

			public void SignalWriter()
			{
			}
		}

		private readonly Func<IAsyncWriter<T>, CancellationToken, UniTask> create;

		public Create(Func<IAsyncWriter<T>, CancellationToken, UniTask> create)
		{
		}

		public IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

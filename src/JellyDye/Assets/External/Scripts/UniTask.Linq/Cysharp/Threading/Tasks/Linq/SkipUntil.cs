using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class SkipUntil<TSource> : IUniTaskAsyncEnumerable<TSource>
	{
		private sealed class _SkipUntil : MoveNextSource, IUniTaskAsyncEnumerator<TSource>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> CancelDelegate1;

			private static readonly Action<object> MoveNextCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private CancellationToken cancellationToken1;

			private bool completed;

			private CancellationTokenRegistration cancellationTokenRegistration1;

			private IUniTaskAsyncEnumerator<TSource> enumerator;

			private UniTask<bool>.Awaiter awaiter;

			private bool continueNext;

			private Exception exception;

			public TSource Current
			{
				[CompilerGenerated]
				get
				{
					return default(TSource);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public _SkipUntil(IUniTaskAsyncEnumerable<TSource> source, UniTask other, CancellationToken cancellationToken1)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private void SourceMoveNext()
			{
			}

			private static void MoveNextCore(object state)
			{
			}

			private UniTaskVoid RunOther(UniTask other)
			{
				return default(UniTaskVoid);
			}

			private static void OnCanceled1(object state)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		private readonly UniTask other;

		private readonly Func<CancellationToken, UniTask> other2;

		public SkipUntil(IUniTaskAsyncEnumerable<TSource> source, UniTask other, Func<CancellationToken, UniTask> other2)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

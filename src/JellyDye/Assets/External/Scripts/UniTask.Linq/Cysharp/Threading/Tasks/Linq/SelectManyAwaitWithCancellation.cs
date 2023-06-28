using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class SelectManyAwaitWithCancellation<TSource, TCollection, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private sealed class _SelectManyAwaitWithCancellation : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> sourceMoveNextCoreDelegate;

			private static readonly Action<object> selectedSourceMoveNextCoreDelegate;

			private static readonly Action<object> selectedEnumeratorDisposeAsyncCoreDelegate;

			private static readonly Action<object> selectorAwaitCoreDelegate;

			private static readonly Action<object> resultSelectorAwaitCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TSource> source;

			private readonly Func<TSource, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TCollection>>> selector1;

			private readonly Func<TSource, int, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TCollection>>> selector2;

			private readonly Func<TSource, TCollection, CancellationToken, UniTask<TResult>> resultSelector;

			private CancellationToken cancellationToken;

			private TSource sourceCurrent;

			private int sourceIndex;

			private IUniTaskAsyncEnumerator<TSource> sourceEnumerator;

			private IUniTaskAsyncEnumerator<TCollection> selectedEnumerator;

			private UniTask<bool>.Awaiter sourceAwaiter;

			private UniTask<bool>.Awaiter selectedAwaiter;

			private UniTask.Awaiter selectedDisposeAsyncAwaiter;

			private UniTask<IUniTaskAsyncEnumerable<TCollection>>.Awaiter collectionSelectorAwaiter;

			private UniTask<TResult>.Awaiter resultSelectorAwaiter;

			public TResult Current
			{
				[CompilerGenerated]
				get
				{
					return default(TResult);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public _SelectManyAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TCollection>>> selector1, Func<TSource, int, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TCollection>>> selector2, Func<TSource, TCollection, CancellationToken, UniTask<TResult>> resultSelector, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private void MoveNextSource()
			{
			}

			private void MoveNextSelected()
			{
			}

			private static void SourceMoveNextCore(object state)
			{
			}

			private static void SeletedSourceMoveNextCore(object state)
			{
			}

			private static void SelectedEnumeratorDisposeAsyncCore(object state)
			{
			}

			private static void SelectorAwaitCore(object state)
			{
			}

			private static void ResultSelectorAwaitCore(object state)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		private readonly Func<TSource, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TCollection>>> selector1;

		private readonly Func<TSource, int, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TCollection>>> selector2;

		private readonly Func<TSource, TCollection, CancellationToken, UniTask<TResult>> resultSelector;

		public SelectManyAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TCollection>>> selector, Func<TSource, TCollection, CancellationToken, UniTask<TResult>> resultSelector)
		{
		}

		public SelectManyAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, int, CancellationToken, UniTask<IUniTaskAsyncEnumerable<TCollection>>> selector, Func<TSource, TCollection, CancellationToken, UniTask<TResult>> resultSelector)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

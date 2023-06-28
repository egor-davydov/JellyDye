using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class JoinAwait<TOuter, TInner, TKey, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private sealed class _JoinAwait : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> MoveNextCoreDelegate;

			private static readonly Action<object> OuterSelectCoreDelegate;

			private static readonly Action<object> ResultSelectCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TOuter> outer;

			private readonly IUniTaskAsyncEnumerable<TInner> inner;

			private readonly Func<TOuter, UniTask<TKey>> outerKeySelector;

			private readonly Func<TInner, UniTask<TKey>> innerKeySelector;

			private readonly Func<TOuter, TInner, UniTask<TResult>> resultSelector;

			private readonly IEqualityComparer<TKey> comparer;

			private CancellationToken cancellationToken;

			private ILookup<TKey, TInner> lookup;

			private IUniTaskAsyncEnumerator<TOuter> enumerator;

			private UniTask<bool>.Awaiter awaiter;

			private TOuter currentOuterValue;

			private IEnumerator<TInner> valueEnumerator;

			private UniTask<TResult>.Awaiter resultAwaiter;

			private UniTask<TKey>.Awaiter outerKeyAwaiter;

			private bool continueNext;

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

			public _JoinAwait(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask<TKey>> outerKeySelector, Func<TInner, UniTask<TKey>> innerKeySelector, Func<TOuter, TInner, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private UniTaskVoid CreateInnerHashSet()
			{
				return default(UniTaskVoid);
			}

			private void SourceMoveNext()
			{
			}

			private static void MoveNextCore(object state)
			{
			}

			private static void OuterSelectCore(object state)
			{
			}

			private static void ResultSelectCore(object state)
			{
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		private readonly IUniTaskAsyncEnumerable<TOuter> outer;

		private readonly IUniTaskAsyncEnumerable<TInner> inner;

		private readonly Func<TOuter, UniTask<TKey>> outerKeySelector;

		private readonly Func<TInner, UniTask<TKey>> innerKeySelector;

		private readonly Func<TOuter, TInner, UniTask<TResult>> resultSelector;

		private readonly IEqualityComparer<TKey> comparer;

		public JoinAwait(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask<TKey>> outerKeySelector, Func<TInner, UniTask<TKey>> innerKeySelector, Func<TOuter, TInner, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

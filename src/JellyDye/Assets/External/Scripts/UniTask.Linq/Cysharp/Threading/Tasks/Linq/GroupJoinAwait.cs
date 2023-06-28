using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class GroupJoinAwait<TOuter, TInner, TKey, TResult> : IUniTaskAsyncEnumerable<TResult>
	{
		private sealed class _GroupJoinAwait : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
		{
			private static readonly Action<object> MoveNextCoreDelegate;

			private static readonly Action<object> ResultSelectCoreDelegate;

			private static readonly Action<object> OuterKeySelectCoreDelegate;

			private readonly IUniTaskAsyncEnumerable<TOuter> outer;

			private readonly IUniTaskAsyncEnumerable<TInner> inner;

			private readonly Func<TOuter, UniTask<TKey>> outerKeySelector;

			private readonly Func<TInner, UniTask<TKey>> innerKeySelector;

			private readonly Func<TOuter, IEnumerable<TInner>, UniTask<TResult>> resultSelector;

			private readonly IEqualityComparer<TKey> comparer;

			private CancellationToken cancellationToken;

			private ILookup<TKey, TInner> lookup;

			private IUniTaskAsyncEnumerator<TOuter> enumerator;

			private TOuter outerValue;

			private UniTask<bool>.Awaiter awaiter;

			private UniTask<TKey>.Awaiter outerKeyAwaiter;

			private UniTask<TResult>.Awaiter resultAwaiter;

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

			public _GroupJoinAwait(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask<TKey>> outerKeySelector, Func<TInner, UniTask<TKey>> innerKeySelector, Func<TOuter, IEnumerable<TInner>, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private UniTaskVoid CreateLookup()
			{
				return default(UniTaskVoid);
			}

			private void SourceMoveNext()
			{
			}

			private static void MoveNextCore(object state)
			{
			}

			private static void OuterKeySelectCore(object state)
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

		private readonly Func<TOuter, IEnumerable<TInner>, UniTask<TResult>> resultSelector;

		private readonly IEqualityComparer<TKey> comparer;

		public GroupJoinAwait(IUniTaskAsyncEnumerable<TOuter> outer, IUniTaskAsyncEnumerable<TInner> inner, Func<TOuter, UniTask<TKey>> outerKeySelector, Func<TInner, UniTask<TKey>> innerKeySelector, Func<TOuter, IEnumerable<TInner>, UniTask<TResult>> resultSelector, IEqualityComparer<TKey> comparer)
		{
		}

		public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

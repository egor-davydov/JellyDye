using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal sealed class DistinctAwaitWithCancellation<TSource, TKey> : IUniTaskAsyncEnumerable<TSource>
	{
		private class _DistinctAwaitWithCancellation : AsyncEnumeratorAwaitSelectorBase<TSource, TSource, TKey>
		{
			private readonly HashSet<TKey> set;

			private readonly Func<TSource, CancellationToken, UniTask<TKey>> keySelector;

			public _DistinctAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
			{
				((AsyncEnumeratorAwaitSelectorBase<, , >)(object)this)._002Ector((IUniTaskAsyncEnumerable<TSource>)null, default(CancellationToken));
			}

			protected override UniTask<TKey> TransformAsync(TSource sourceCurrent)
			{
				return default(UniTask<TKey>);
			}

			protected override bool TrySetCurrentCore(TKey awaitResult, out bool terminateIteration)
			{
				terminateIteration = default(bool);
				return false;
			}
		}

		private readonly IUniTaskAsyncEnumerable<TSource> source;

		private readonly Func<TSource, CancellationToken, UniTask<TKey>> keySelector;

		private readonly IEqualityComparer<TKey> comparer;

		public DistinctAwaitWithCancellation(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer)
		{
		}

		public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}

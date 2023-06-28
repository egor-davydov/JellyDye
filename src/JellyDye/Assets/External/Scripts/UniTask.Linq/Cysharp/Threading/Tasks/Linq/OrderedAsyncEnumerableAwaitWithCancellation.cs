using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class OrderedAsyncEnumerableAwaitWithCancellation<TElement, TKey> : OrderedAsyncEnumerable<TElement>
	{
		private readonly Func<TElement, CancellationToken, UniTask<TKey>> keySelector;

		private readonly IComparer<TKey> comparer;

		private readonly bool descending;

		private readonly OrderedAsyncEnumerable<TElement> parent;

		public OrderedAsyncEnumerableAwaitWithCancellation(IUniTaskAsyncEnumerable<TElement> source, Func<TElement, CancellationToken, UniTask<TKey>> keySelector, IComparer<TKey> comparer, bool descending, OrderedAsyncEnumerable<TElement> parent)
		{
			((OrderedAsyncEnumerable<>)(object)this)._002Ector((IUniTaskAsyncEnumerable<TElement>)null);
		}

		internal override AsyncEnumerableSorter<TElement> GetAsyncEnumerableSorter(AsyncEnumerableSorter<TElement> next, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}

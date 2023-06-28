using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal abstract class OrderedAsyncEnumerable<TElement> : IUniTaskOrderedAsyncEnumerable<TElement>, IUniTaskAsyncEnumerable<TElement>
	{
		private class _OrderedAsyncEnumerator : MoveNextSource, IUniTaskAsyncEnumerator<TElement>, IUniTaskAsyncDisposable
		{
			protected readonly OrderedAsyncEnumerable<TElement> parent;

			private CancellationToken cancellationToken;

			private TElement[] buffer;

			private int[] map;

			private int index;

			public TElement Current
			{
				[CompilerGenerated]
				get
				{
					return default(TElement);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public _OrderedAsyncEnumerator(OrderedAsyncEnumerable<TElement> parent, CancellationToken cancellationToken)
			{
			}

			public UniTask<bool> MoveNextAsync()
			{
				return default(UniTask<bool>);
			}

			private UniTaskVoid CreateSortSource()
			{
				return default(UniTaskVoid);
			}

			public UniTask DisposeAsync()
			{
				return default(UniTask);
			}
		}

		protected readonly IUniTaskAsyncEnumerable<TElement> source;

		public OrderedAsyncEnumerable(IUniTaskAsyncEnumerable<TElement> source)
		{
		}

		public IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
		{
			return null;
		}

		public IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, UniTask<TKey>> keySelector, IComparer<TKey> comparer, bool descending)
		{
			return null;
		}

		public IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, CancellationToken, UniTask<TKey>> keySelector, IComparer<TKey> comparer, bool descending)
		{
			return null;
		}

		internal abstract AsyncEnumerableSorter<TElement> GetAsyncEnumerableSorter(AsyncEnumerableSorter<TElement> next, CancellationToken cancellationToken);

		public IUniTaskAsyncEnumerator<TElement> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
	internal class OrderedAsyncEnumerable<TElement, TKey> : OrderedAsyncEnumerable<TElement>
	{
		private readonly Func<TElement, TKey> keySelector;

		private readonly IComparer<TKey> comparer;

		private readonly bool descending;

		private readonly OrderedAsyncEnumerable<TElement> parent;

		public OrderedAsyncEnumerable(IUniTaskAsyncEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, OrderedAsyncEnumerable<TElement> parent)
		{
			((OrderedAsyncEnumerable<>)(object)this)._002Ector((IUniTaskAsyncEnumerable<TElement>)null);
		}

		internal override AsyncEnumerableSorter<TElement> GetAsyncEnumerableSorter(AsyncEnumerableSorter<TElement> next, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class ToLookup
	{
		private class Lookup<TKey, TElement> : ILookup<TKey, TElement>, IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
		{
			private static readonly Lookup<TKey, TElement> empty;

			private readonly Dictionary<TKey, Grouping<TKey, TElement>> dict;

			public IEnumerable<TElement> Item => null;

			public int Count => 0;

			private Lookup(Dictionary<TKey, Grouping<TKey, TElement>> dict)
			{
			}

			public static Lookup<TKey, TElement> CreateEmpty()
			{
				return null;
			}

			public static Lookup<TKey, TElement> Create(ArraySegment<TElement> source, Func<TElement, TKey> keySelector, IEqualityComparer<TKey> comparer)
			{
				return null;
			}

			public static Lookup<TKey, TElement> Create<TSource>(ArraySegment<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
			{
				return null;
			}

			public static UniTask<Lookup<TKey, TElement>> CreateAsync(ArraySegment<TElement> source, Func<TElement, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer)
			{
				return default(UniTask<Lookup<TKey, TElement>>);
			}

			public static UniTask<Lookup<TKey, TElement>> CreateAsync<TSource>(ArraySegment<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer)
			{
				return default(UniTask<Lookup<TKey, TElement>>);
			}

			public static UniTask<Lookup<TKey, TElement>> CreateAsync(ArraySegment<TElement> source, Func<TElement, CancellationToken, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
			{
				return default(UniTask<Lookup<TKey, TElement>>);
			}

			public static UniTask<Lookup<TKey, TElement>> CreateAsync<TSource>(ArraySegment<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
			{
				return default(UniTask<Lookup<TKey, TElement>>);
			}

			public bool Contains(TKey key)
			{
				return false;
			}

			public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
			{
				return null;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		private class Grouping<TKey, TElement> : IGrouping<TKey, TElement>, IEnumerable<TElement>, IEnumerable
		{
			private readonly List<TElement> elements;

			public TKey Key
			{
				[CompilerGenerated]
				get
				{
					return default(TKey);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Grouping(TKey key)
			{
			}

			public void Add(TElement value)
			{
			}

			public IEnumerator<TElement> GetEnumerator()
			{
				return null;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			public IUniTaskAsyncEnumerator<TElement> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
			{
				return null;
			}

			public override string ToString()
			{
				return null;
			}
		}

		internal static UniTask<ILookup<TKey, TSource>> ToLookupAsync<TSource, TKey>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
		{
			return default(UniTask<ILookup<TKey, TSource>>);
		}

		internal static UniTask<ILookup<TKey, TElement>> ToLookupAsync<TSource, TKey, TElement>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
		{
			return default(UniTask<ILookup<TKey, TElement>>);
		}

		internal static UniTask<ILookup<TKey, TSource>> ToLookupAwaitAsync<TSource, TKey>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
		{
			return default(UniTask<ILookup<TKey, TSource>>);
		}

		internal static UniTask<ILookup<TKey, TElement>> ToLookupAwaitAsync<TSource, TKey, TElement>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<TKey>> keySelector, Func<TSource, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
		{
			return default(UniTask<ILookup<TKey, TElement>>);
		}

		internal static UniTask<ILookup<TKey, TSource>> ToLookupAwaitWithCancellationAsync<TSource, TKey>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
		{
			return default(UniTask<ILookup<TKey, TSource>>);
		}

		internal static UniTask<ILookup<TKey, TElement>> ToLookupAwaitWithCancellationAsync<TSource, TKey, TElement>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<TKey>> keySelector, Func<TSource, CancellationToken, UniTask<TElement>> elementSelector, IEqualityComparer<TKey> comparer, CancellationToken cancellationToken)
		{
			return default(UniTask<ILookup<TKey, TElement>>);
		}
	}
}

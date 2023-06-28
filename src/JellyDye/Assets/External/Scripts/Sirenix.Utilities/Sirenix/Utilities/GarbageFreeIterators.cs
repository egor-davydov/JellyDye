using System;
using System.Collections.Generic;

namespace Sirenix.Utilities
{
	public static class GarbageFreeIterators
	{
		public struct ListIterator<T> : IDisposable
		{
			private bool isNull;

			private List<T> list;

			private List<T>.Enumerator enumerator;

			public T Current => default(T);

			public ListIterator(List<T> list)
			{
			}

			public ListIterator<T> GetEnumerator()
			{
				return default(ListIterator<T>);
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Dispose()
			{
			}
		}

		public struct HashsetIterator<T> : IDisposable
		{
			private bool isNull;

			private HashSet<T> hashset;

			private HashSet<T>.Enumerator enumerator;

			public T Current => default(T);

			public HashsetIterator(HashSet<T> hashset)
			{
			}

			public HashsetIterator<T> GetEnumerator()
			{
				return default(HashsetIterator<T>);
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Dispose()
			{
			}
		}

		public struct DictionaryIterator<T1, T2> : IDisposable
		{
			private Dictionary<T1, T2> dictionary;

			private Dictionary<T1, T2>.Enumerator enumerator;

			private bool isNull;

			public KeyValuePair<T1, T2> Current => default(KeyValuePair<T1, T2>);

			public DictionaryIterator(Dictionary<T1, T2> dictionary)
			{
			}

			public DictionaryIterator<T1, T2> GetEnumerator()
			{
				return default(DictionaryIterator<T1, T2>);
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Dispose()
			{
			}
		}

		public struct DictionaryValueIterator<T1, T2> : IDisposable
		{
			private Dictionary<T1, T2> dictionary;

			private Dictionary<T1, T2>.Enumerator enumerator;

			private bool isNull;

			public T2 Current => default(T2);

			public DictionaryValueIterator(Dictionary<T1, T2> dictionary)
			{
			}

			public DictionaryValueIterator<T1, T2> GetEnumerator()
			{
				return default(DictionaryValueIterator<T1, T2>);
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Dispose()
			{
			}
		}

		public static ListIterator<T> GFIterator<T>(this List<T> list)
		{
			return default(ListIterator<T>);
		}

		public static DictionaryIterator<T1, T2> GFIterator<T1, T2>(this Dictionary<T1, T2> dictionary)
		{
			return default(DictionaryIterator<T1, T2>);
		}

		public static DictionaryValueIterator<T1, T2> GFValueIterator<T1, T2>(this Dictionary<T1, T2> dictionary)
		{
			return default(DictionaryValueIterator<T1, T2>);
		}

		public static HashsetIterator<T> GFIterator<T>(this HashSet<T> hashset)
		{
			return default(HashsetIterator<T>);
		}
	}
}

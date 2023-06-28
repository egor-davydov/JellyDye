using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Internal
{
	internal class WeakDictionary<TKey, TValue> where TKey : class
	{
		private class Entry
		{
			public WeakReference<TKey> Key;

			public TValue Value;

			public int Hash;

			public Entry Prev;

			public Entry Next;

			public override string ToString()
			{
				return null;
			}

			private int Count()
			{
				return 0;
			}
		}

		private Entry[] buckets;

		private int size;

		private SpinLock gate;

		private readonly float loadFactor;

		private readonly IEqualityComparer<TKey> keyEqualityComparer;

		public WeakDictionary(int capacity = 4, float loadFactor = 0.75f, IEqualityComparer<TKey> keyComparer = null)
		{
		}

		public bool TryAdd(TKey key, TValue value)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public bool TryRemove(TKey key)
		{
			return false;
		}

		private bool TryAddInternal(TKey key, TValue value)
		{
			return false;
		}

		private bool AddToBuckets(Entry[] targetBuckets, TKey newKey, TValue value, int keyHash)
		{
			return false;
		}

		private bool TryGetEntry(TKey key, out int hashIndex, out Entry entry)
		{
			hashIndex = default(int);
			entry = null;
			return false;
		}

		private void Remove(int hashIndex, Entry entry)
		{
		}

		public List<KeyValuePair<TKey, TValue>> ToList()
		{
			return null;
		}

		public int ToList(ref List<KeyValuePair<TKey, TValue>> list, bool clear = true)
		{
			return 0;
		}

		private static int CalculateCapacity(int collectionSize, float loadFactor)
		{
			return 0;
		}
	}
}

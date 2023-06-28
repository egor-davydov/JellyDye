using System;
using System.Collections;
using System.Collections.Generic;

namespace Sirenix.Utilities
{
	[Serializable]
	public class IndexedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IEnumerable, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IDictionary, ICollection
	{
		private Dictionary<TKey, TValue> dictionary;

		private List<TKey> indexer;

		public ICollection<TKey> Keys => null;

		public ICollection<TValue> Values => null;

		public int Count => 0;

		public bool IsReadOnly => false;

		private bool System_002ECollections_002EIDictionary_002EIsFixedSize => false;

		private bool System_002ECollections_002EIDictionary_002EIsReadOnly => false;

		private ICollection System_002ECollections_002EIDictionary_002EKeys => null;

		private ICollection System_002ECollections_002EIDictionary_002EValues => null;

		private int System_002ECollections_002EICollection_002ECount => 0;

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private object System_002ECollections_002EIDictionary_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TValue Item
		{
			get
			{
				return default(TValue);
			}
			set
			{
			}
		}

		public IndexedDictionary()
		{
		}

		public IndexedDictionary(int capacity)
		{
		}

		public KeyValuePair<TKey, TValue> Get(int index)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		public TKey GetKey(int index)
		{
			return default(TKey);
		}

		public TValue GetValue(int index)
		{
			return default(TValue);
		}

		public int IndexOf(TKey key)
		{
			return 0;
		}

		public void Add(TKey key, TValue value)
		{
		}

		public void Clear()
		{
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public void RemoveAt(int index)
		{
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
		{
		}

		private void System_002ECollections_002EIDictionary_002EClear()
		{
		}

		private bool System_002ECollections_002EIDictionary_002EContains(object key)
		{
			return false;
		}

		private IDictionaryEnumerator System_002ECollections_002EIDictionary_002EGetEnumerator()
		{
			return null;
		}

		private void System_002ECollections_002EIDictionary_002ERemove(object key)
		{
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}
	}
}

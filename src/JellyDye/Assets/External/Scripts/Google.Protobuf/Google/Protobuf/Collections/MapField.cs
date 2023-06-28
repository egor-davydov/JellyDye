using System;
using System.Collections;
using System.Collections.Generic;

namespace Google.Protobuf.Collections
{
	public sealed class MapField<TKey, TValue> : IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IEquatable<MapField<TKey, TValue>>, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		private class DictionaryEnumerator : IDictionaryEnumerator, IEnumerator
		{
			private readonly IEnumerator<KeyValuePair<TKey, TValue>> enumerator;

			public object Current => null;

			public DictionaryEntry Entry => default(DictionaryEntry);

			public object Key => null;

			public object Value => null;

			internal DictionaryEnumerator(IEnumerator<KeyValuePair<TKey, TValue>> enumerator)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		public sealed class Codec
		{
			private readonly FieldCodec<TKey> keyCodec;

			private readonly FieldCodec<TValue> valueCodec;

			private readonly uint mapTag;

			internal FieldCodec<TKey> KeyCodec => null;

			internal FieldCodec<TValue> ValueCodec => null;

			internal uint MapTag => 0u;

			public Codec(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag)
			{
			}
		}

		private class MapView<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection
		{
			private readonly MapField<TKey, TValue> parent;

			private readonly Func<KeyValuePair<TKey, TValue>, T> projection;

			private readonly Func<T, bool> containsCheck;

			public int Count => 0;

			public bool IsReadOnly => false;

			public bool IsSynchronized => false;

			public object SyncRoot => null;

			internal MapView(MapField<TKey, TValue> parent, Func<KeyValuePair<TKey, TValue>, T> projection, Func<T, bool> containsCheck)
			{
			}

			public void Add(T item)
			{
			}

			public void Clear()
			{
			}

			public bool Contains(T item)
			{
				return false;
			}

			public void CopyTo(T[] array, int arrayIndex)
			{
			}

			public IEnumerator<T> GetEnumerator()
			{
				return null;
			}

			public bool Remove(T item)
			{
				return false;
			}

			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}

			public void CopyTo(Array array, int index)
			{
			}
		}

		private static readonly EqualityComparer<TValue> ValueEqualityComparer;

		private static readonly EqualityComparer<TKey> KeyEqualityComparer;

		private readonly Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>> map;

		private readonly LinkedList<KeyValuePair<TKey, TValue>> list;

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

		public ICollection<TKey> Keys => null;

		public ICollection<TValue> Values => null;

		public int Count => 0;

		public bool IsReadOnly => false;

		private bool System_002ECollections_002EIDictionary_002EIsFixedSize => false;

		private ICollection System_002ECollections_002EIDictionary_002EKeys => null;

		private ICollection System_002ECollections_002EIDictionary_002EValues => null;

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

		public MapField<TKey, TValue> Clone()
		{
			return null;
		}

		public void Add(TKey key, TValue value)
		{
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		private bool ContainsValue(TValue value)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default(TValue);
			return false;
		}

		public void Add(IDictionary<TKey, TValue> entries)
		{
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EAdd(KeyValuePair<TKey, TValue> item)
		{
		}

		public void Clear()
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002EContains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ECopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002ECollections_002EGeneric_002EKeyValuePair_003CTKey_002CTValue_003E_003E_002ERemove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(MapField<TKey, TValue> other)
		{
			return false;
		}

		public void AddEntriesFrom(CodedInputStream input, Codec codec)
		{
		}

		public void AddEntriesFrom(ref ParseContext ctx, Codec codec)
		{
		}

		public void WriteTo(CodedOutputStream output, Codec codec)
		{
		}

		public void WriteTo(ref WriteContext ctx, Codec codec)
		{
		}

		public int CalculateSize(Codec codec)
		{
			return 0;
		}

		private static int CalculateEntrySize(Codec codec, KeyValuePair<TKey, TValue> entry)
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		private void System_002ECollections_002EIDictionary_002EAdd(object key, object value)
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

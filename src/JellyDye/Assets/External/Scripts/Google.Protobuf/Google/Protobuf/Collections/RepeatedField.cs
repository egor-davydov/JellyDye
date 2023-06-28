using System;
using System.Collections;
using System.Collections.Generic;

namespace Google.Protobuf.Collections
{
	public sealed class RepeatedField<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>>, IReadOnlyList<T>, IReadOnlyCollection<T>
	{
		private static readonly EqualityComparer<T> EqualityComparer;

		private static readonly T[] EmptyArray;

		private const int MinArraySize = 8;

		private T[] array;

		private int count;

		public int Count => 0;

		public bool IsReadOnly => false;

		public T Item
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		private bool System_002ECollections_002EIList_002EIsFixedSize => false;

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private object System_002ECollections_002EIList_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RepeatedField<T> Clone()
		{
			return null;
		}

		public void AddEntriesFrom(CodedInputStream input, FieldCodec<T> codec)
		{
		}

		public void AddEntriesFrom(ref ParseContext ctx, FieldCodec<T> codec)
		{
		}

		public int CalculateSize(FieldCodec<T> codec)
		{
			return 0;
		}

		private int CalculatePackedDataSize(FieldCodec<T> codec)
		{
			return 0;
		}

		public void WriteTo(CodedOutputStream output, FieldCodec<T> codec)
		{
		}

		public void WriteTo(ref WriteContext ctx, FieldCodec<T> codec)
		{
		}

		private void EnsureSize(int size)
		{
		}

		private void SetSize(int size)
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

		public bool Remove(T item)
		{
			return false;
		}

		public void AddRange(IEnumerable<T> values)
		{
		}

		public void Add(IEnumerable<T> values)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool Equals(RepeatedField<T> other)
		{
			return false;
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		public void Insert(int index, T item)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private bool System_002ECollections_002EIList_002EContains(object value)
		{
			return false;
		}

		private int System_002ECollections_002EIList_002EIndexOf(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}
	}
}

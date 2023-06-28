using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace SRF
{
	[Serializable]
	public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver
	{
		[SerializeField]
		private T[] _buffer;

		[SerializeField]
		private int _count;

		private EqualityComparer<T> _equalityComparer;

		private ReadOnlyCollection<T> _readOnlyWrapper;

		public T[] Buffer
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private EqualityComparer<T> EqualityComparer => null;

		public int Count
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

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

		public SRList()
		{
		}

		public SRList(int capacity)
		{
		}

		public SRList(IEnumerable<T> source)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
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

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void AddRange(IEnumerable<T> range)
		{
		}

		public void Clear(bool clean)
		{
		}

		public void Clean()
		{
		}

		public ReadOnlyCollection<T> AsReadOnly()
		{
			return null;
		}

		private void Expand()
		{
		}

		public void Trim()
		{
		}

		public void Sort(Comparison<T> comparer)
		{
		}
	}
}

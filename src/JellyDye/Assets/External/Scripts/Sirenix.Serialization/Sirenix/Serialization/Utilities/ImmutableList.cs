using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sirenix.Serialization.Utilities
{
	[Serializable]
	internal sealed class ImmutableList : IImmutableList<object>, IImmutableList, IList, IEnumerable, ICollection, IList<object>, ICollection<object>, IEnumerable<object>
	{
		[SerializeField]
		private IList innerList;

		public int Count => 0;

		public bool IsFixedSize => false;

		public bool IsReadOnly => false;

		public bool IsSynchronized => false;

		public object SyncRoot => null;

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

		private object System_002ECollections_002EGeneric_002EIList_003CSystem_002EObject_003E_002EItem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object Item => null;

		public ImmutableList(IList innerList)
		{
		}

		public bool Contains(object value)
		{
			return false;
		}

		public void CopyTo(object[] array, int arrayIndex)
		{
		}

		public void CopyTo(Array array, int index)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private IEnumerator<object> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EObject_003E_002EGetEnumerator()
		{
			return null;
		}

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EClear()
		{
		}

		private void System_002ECollections_002EIList_002EInsert(int index, object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemove(object value)
		{
		}

		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		public int IndexOf(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EGeneric_002EIList_003CSystem_002EObject_003E_002ERemoveAt(int index)
		{
		}

		private void System_002ECollections_002EGeneric_002EIList_003CSystem_002EObject_003E_002EInsert(int index, object item)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002EObject_003E_002EAdd(object item)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CSystem_002EObject_003E_002EClear()
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CSystem_002EObject_003E_002ERemove(object item)
		{
			return false;
		}
	}
	[Serializable]
	public sealed class ImmutableList<T> : IImmutableList<T>, IImmutableList, IList, IEnumerable, ICollection, IList<T>, ICollection<T>, IEnumerable<T>
	{
		[SerializeField]
		private IList<T> innerList;

		public int Count => 0;

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private bool System_002ECollections_002EIList_002EIsFixedSize => false;

		private bool System_002ECollections_002EIList_002EIsReadOnly => false;

		public bool IsReadOnly => false;

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

		private T System_002ECollections_002EGeneric_002EIList_003CT_003E_002EItem
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public T Item => default(T);

		public ImmutableList(IList<T> innerList)
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

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EAdd(T item)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EClear()
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002ERemove(T item)
		{
			return false;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EClear()
		{
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

		private void System_002ECollections_002EGeneric_002EIList_003CT_003E_002EInsert(int index, T item)
		{
		}

		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		public int IndexOf(T item)
		{
			return 0;
		}

		private void System_002ECollections_002EGeneric_002EIList_003CT_003E_002ERemoveAt(int index)
		{
		}
	}
	[Serializable]
	public sealed class ImmutableList<TList, TElement> : IImmutableList<TElement>, IImmutableList, IList, IEnumerable, ICollection, IList<TElement>, ICollection<TElement>, IEnumerable<TElement> where TList : IList<TElement>
	{
		private TList innerList;

		public int Count => 0;

		private bool System_002ECollections_002EICollection_002EIsSynchronized => false;

		private object System_002ECollections_002EICollection_002ESyncRoot => null;

		private bool System_002ECollections_002EIList_002EIsFixedSize => false;

		private bool System_002ECollections_002EIList_002EIsReadOnly => false;

		public bool IsReadOnly => false;

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

		private TElement System_002ECollections_002EGeneric_002EIList_003CTElement_003E_002EItem
		{
			get
			{
				return default(TElement);
			}
			set
			{
			}
		}

		public TElement Item => default(TElement);

		public ImmutableList(TList innerList)
		{
		}

		public bool Contains(TElement item)
		{
			return false;
		}

		public void CopyTo(TElement[] array, int arrayIndex)
		{
		}

		public IEnumerator<TElement> GetEnumerator()
		{
			return null;
		}

		private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CTElement_003E_002EAdd(TElement item)
		{
		}

		private void System_002ECollections_002EGeneric_002EICollection_003CTElement_003E_002EClear()
		{
		}

		private bool System_002ECollections_002EGeneric_002EICollection_003CTElement_003E_002ERemove(TElement item)
		{
			return false;
		}

		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		private int System_002ECollections_002EIList_002EAdd(object value)
		{
			return 0;
		}

		private void System_002ECollections_002EIList_002EClear()
		{
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

		private void System_002ECollections_002EGeneric_002EIList_003CTElement_003E_002EInsert(int index, TElement item)
		{
		}

		private void System_002ECollections_002EIList_002ERemoveAt(int index)
		{
		}

		public int IndexOf(TElement item)
		{
			return 0;
		}

		private void System_002ECollections_002EGeneric_002EIList_003CTElement_003E_002ERemoveAt(int index)
		{
		}
	}
}

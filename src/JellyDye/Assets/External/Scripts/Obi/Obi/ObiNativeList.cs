using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace Obi
{
	public abstract class ObiNativeList<T> : IEnumerable<T>, IEnumerable, IDisposable, ISerializationCallbackReceiver where T : struct
	{
		public T[] serializedContents;

		protected unsafe void* m_AlignedPtr;

		protected int m_Stride;

		protected int m_Capacity;

		protected int m_Count;

		protected bool m_AsNativeArray;

		protected ComputeBuffer m_ComputeBuffer;

		public int count
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int capacity
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isCreated => false;

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

		public ObiNativeList(int capacity = 8, int alignment = 16)
		{
		}

		~ObiNativeList()
		{
		}

		protected void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public NativeArray<U> AsNativeArray<U>() where U : struct
		{
			return default(NativeArray<U>);
		}

		public NativeArray<U> AsNativeArray<U>(int arrayLength) where U : struct
		{
			return default(NativeArray<U>);
		}

		public ComputeBuffer AsComputeBuffer<U>() where U : struct
		{
			return null;
		}

		protected void ChangeCapacity(int newCapacity, int byteAlignment = 16)
		{
		}

		public bool Compare(ObiNativeList<T> other)
		{
			return false;
		}

		public void CopyFrom(ObiNativeList<T> source)
		{
		}

		public void CopyFrom(ObiNativeList<T> source, int sourceIndex, int destIndex, int length)
		{
		}

		public void CopyReplicate(T value, int destIndex, int length)
		{
		}

		public void CopyTo(T[] dest, int sourceIndex, int length)
		{
		}

		public void Clear()
		{
		}

		public void Add(T item)
		{
		}

		public void AddRange(IEnumerable<T> enumerable)
		{
		}

		public void RemoveRange(int index, int count)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public bool ResizeUninitialized(int newCount)
		{
			return false;
		}

		public bool ResizeInitialized(int newCount, T value = default(T))
		{
			return false;
		}

		public bool EnsureCapacity(int min)
		{
			return false;
		}

		public void WipeToZero()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public unsafe void* AddressOfElement(int index)
		{
			//IL_0002: Expected I, but got O
			return (void*)(IntPtr)null;
		}

		public IntPtr GetIntPtr()
		{
			return (IntPtr)0;
		}

		public void Swap(int index1, int index2)
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
	}
}

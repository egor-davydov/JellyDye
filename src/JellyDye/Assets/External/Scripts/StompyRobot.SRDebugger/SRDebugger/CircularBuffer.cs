using System;
using System.Collections;
using System.Collections.Generic;

namespace SRDebugger
{
	public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T>
	{
		private readonly T[] _buffer;

		private int _end;

		private int _count;

		private int _start;

		public int Capacity => 0;

		public bool IsFull => false;

		public bool IsEmpty => false;

		public int Count => 0;

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

		public CircularBuffer(int capacity)
		{
		}

		public CircularBuffer(int capacity, T[] items)
		{
		}

		public void Clear()
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

		public T Front()
		{
			return default(T);
		}

		public T Back()
		{
			return default(T);
		}

		public void PushBack(T item)
		{
		}

		public void PushFront(T item)
		{
		}

		public void PopBack()
		{
		}

		public void PopFront()
		{
		}

		public T[] ToArray()
		{
			return null;
		}

		private void ThrowIfEmpty(string message = "Cannot access an empty buffer.")
		{
		}

		private void Increment(ref int index)
		{
		}

		private void Decrement(ref int index)
		{
		}

		private int InternalIndex(int index)
		{
			return 0;
		}

		private ArraySegment<T> ArrayOne()
		{
			return default(ArraySegment<T>);
		}

		private ArraySegment<T> ArrayTwo()
		{
			return default(ArraySegment<T>);
		}
	}
}

using System;

namespace Unity.Services.Core.Scheduler.Internal
{
	internal class MinimumBinaryHeap<T> where T : IComparable<T>
	{
		private readonly int m_MinimumCapacity;

		private T[] m_HeapArray;

		private int m_Count;

		public int Count => 0;

		public T Min => default(T);

		public MinimumBinaryHeap(int capacity = 10)
		{
		}

		public void Insert(T data)
		{
		}

		private void IncreaseHeapCapacityWhenFull()
		{
		}

		public void Remove(T data)
		{
		}

		public T ExtractMin()
		{
			return default(T);
		}

		private void DecreaseHeapCapacityWhenSpare()
		{
		}

		private int GetKey(T data)
		{
			return 0;
		}

		private void MinHeapify(int key)
		{
		}

		private static void Swap(ref T lhs, ref T rhs)
		{
		}

		private static int Parent(int key)
		{
			return 0;
		}

		private static int LeftChild(int key)
		{
			return 0;
		}

		private static int RightChild(int key)
		{
			return 0;
		}
	}
}

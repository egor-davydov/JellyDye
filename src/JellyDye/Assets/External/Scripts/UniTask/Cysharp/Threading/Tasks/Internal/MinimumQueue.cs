using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks.Internal
{
	internal class MinimumQueue<T>
	{
		private const int MinimumGrow = 4;

		private const int GrowFactor = 200;

		private T[] array;

		private int head;

		private int tail;

		private int size;

		public int Count
		{
			[MethodImpl(256)]
			get
			{
				return 0;
			}
		}

		public MinimumQueue(int capacity)
		{
		}

		public T Peek()
		{
			return default(T);
		}

		[MethodImpl(256)]
		public void Enqueue(T item)
		{
		}

		[MethodImpl(256)]
		public T Dequeue()
		{
			return default(T);
		}

		private void Grow()
		{
		}

		private void SetCapacity(int capacity)
		{
		}

		[MethodImpl(256)]
		private void MoveNext(ref int index)
		{
		}

		private void ThrowForEmptyQueue()
		{
		}
	}
}

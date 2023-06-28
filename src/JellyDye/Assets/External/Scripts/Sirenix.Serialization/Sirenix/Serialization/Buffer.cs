using System;
using System.Collections.Generic;

namespace Sirenix.Serialization
{
	public sealed class Buffer<T> : IDisposable
	{
		private static readonly object LOCK;

		private static readonly List<Buffer<T>> FreeBuffers;

		private int count;

		private T[] array;

		private bool isFree;

		public int Count => 0;

		public T[] Array => null;

		public bool IsFree => false;

		private Buffer(int count)
		{
		}

		public static Buffer<T> Claim(int minimumCapacity)
		{
			return null;
		}

		public static void Free(Buffer<T> buffer)
		{
		}

		public void Free()
		{
		}

		public void Dispose()
		{
		}

		private static int NextPowerOfTwo(int v)
		{
			return 0;
		}
	}
}

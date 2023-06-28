using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks.Internal
{
	internal static class ArrayPoolUtil
	{
		public struct RentArray<T> : IDisposable
		{
			public readonly T[] Array;

			public readonly int Length;

			private ArrayPool<T> pool;

			public RentArray(T[] array, int length, ArrayPool<T> pool)
			{
			}

			public void Dispose()
			{
			}

			public void DisposeManually(bool clearArray)
			{
			}
		}

		[MethodImpl(256)]
		internal static void EnsureCapacity<T>(ref T[] array, int index, ArrayPool<T> pool)
		{
		}

		[MethodImpl(8)]
		private static void EnsureCapacityCore<T>(ref T[] array, int index, ArrayPool<T> pool)
		{
		}

		public static RentArray<T> Materialize<T>(IEnumerable<T> source)
		{
			return default(RentArray<T>);
		}
	}
}

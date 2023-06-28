using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks.Internal
{
	internal static class ArrayUtil
	{
		[MethodImpl(256)]
		public static void EnsureCapacity<T>(ref T[] array, int index)
		{
		}

		[MethodImpl(8)]
		private static void EnsureCore<T>(ref T[] array, int index)
		{
		}

		public static (T[], int) Materialize<T>(IEnumerable<T> source)
		{
			return default((T[], int));
		}
	}
}

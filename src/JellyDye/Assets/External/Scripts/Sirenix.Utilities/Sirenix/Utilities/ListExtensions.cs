using System;
using System.Collections.Generic;

namespace Sirenix.Utilities
{
	public static class ListExtensions
	{
		public static void SetLength<T>(ref IList<T> list, int length)
		{
		}

		public static void SetLength<T>(ref IList<T> list, int length, Func<T> newElement)
		{
		}

		public static void SetLength<T>(this IList<T> list, int length)
		{
		}

		public static void SetLength<T>(this IList<T> list, int length, Func<T> newElement)
		{
		}
	}
}

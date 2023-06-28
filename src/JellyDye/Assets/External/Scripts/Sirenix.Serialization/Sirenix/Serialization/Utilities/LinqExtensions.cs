using System;
using System.Collections.Generic;

namespace Sirenix.Serialization.Utilities
{
	internal static class LinqExtensions
	{
		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			return null;
		}

		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T, int> action)
		{
			return null;
		}

		public static IEnumerable<T> Append<T>(this IEnumerable<T> source, IEnumerable<T> append)
		{
			return null;
		}
	}
}

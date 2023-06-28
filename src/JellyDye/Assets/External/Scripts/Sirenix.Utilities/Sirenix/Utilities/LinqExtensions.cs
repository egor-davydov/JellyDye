using System;
using System.Collections;
using System.Collections.Generic;

namespace Sirenix.Utilities
{
	public static class LinqExtensions
	{
		public static IEnumerable<T> Examine<T>(this IEnumerable<T> source, Action<T> action)
		{
			return null;
		}

		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T> action)
		{
			return null;
		}

		public static IEnumerable<T> ForEach<T>(this IEnumerable<T> source, Action<T, int> action)
		{
			return null;
		}

		public static IEnumerable<T> Convert<T>(this IEnumerable source, Func<object, T> converter)
		{
			return null;
		}

		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source)
		{
			return null;
		}

		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source, IEqualityComparer<T> comparer)
		{
			return null;
		}

		public static ImmutableList<T> ToImmutableList<T>(this IEnumerable<T> source)
		{
			return null;
		}

		public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, Func<T> prepend)
		{
			return null;
		}

		public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, T prepend)
		{
			return null;
		}

		public static IEnumerable<T> Prepend<T>(this IEnumerable<T> source, IEnumerable<T> prepend)
		{
			return null;
		}

		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, bool condition, Func<T> prepend)
		{
			return null;
		}

		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, bool condition, T prepend)
		{
			return null;
		}

		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, bool condition, IEnumerable<T> prepend)
		{
			return null;
		}

		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<bool> condition, Func<T> prepend)
		{
			return null;
		}

		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<bool> condition, T prepend)
		{
			return null;
		}

		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<bool> condition, IEnumerable<T> prepend)
		{
			return null;
		}

		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<IEnumerable<T>, bool> condition, Func<T> prepend)
		{
			return null;
		}

		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<IEnumerable<T>, bool> condition, T prepend)
		{
			return null;
		}

		public static IEnumerable<T> PrependIf<T>(this IEnumerable<T> source, Func<IEnumerable<T>, bool> condition, IEnumerable<T> prepend)
		{
			return null;
		}

		public static IEnumerable<T> AppendWith<T>(this IEnumerable<T> source, Func<T> append)
		{
			return null;
		}

		public static IEnumerable<T> AppendWith<T>(this IEnumerable<T> source, T append)
		{
			return null;
		}

		public static IEnumerable<T> AppendWith<T>(this IEnumerable<T> source, IEnumerable<T> append)
		{
			return null;
		}

		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, bool condition, Func<T> append)
		{
			return null;
		}

		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, bool condition, T append)
		{
			return null;
		}

		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, bool condition, IEnumerable<T> append)
		{
			return null;
		}

		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, Func<bool> condition, Func<T> append)
		{
			return null;
		}

		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, Func<bool> condition, T append)
		{
			return null;
		}

		public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> source, Func<bool> condition, IEnumerable<T> append)
		{
			return null;
		}

		public static IEnumerable<T> FilterCast<T>(this IEnumerable source)
		{
			return null;
		}

		public static void AddRange<T>(this HashSet<T> hashSet, IEnumerable<T> range)
		{
		}

		public static bool IsNullOrEmpty<T>(this IList<T> list)
		{
			return false;
		}

		public static void Populate<T>(this IList<T> list, T item)
		{
		}

		public static void AddRange<T>(this IList<T> list, IEnumerable<T> collection)
		{
		}

		public static void Sort<T>(this IList<T> list, Comparison<T> comparison)
		{
		}

		public static void Sort<T>(this IList<T> list)
		{
		}
	}
}

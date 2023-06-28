using System;

namespace Sirenix.Utilities
{
	public static class DelegateExtensions
	{
		public static Func<TResult> Memoize<TResult>(this Func<TResult> getValue)
		{
			return null;
		}

		public static Func<T, TResult> Memoize<T, TResult>(this Func<T, TResult> func)
		{
			return null;
		}
	}
}

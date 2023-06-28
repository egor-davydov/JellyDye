using System.Collections.Generic;

namespace Sirenix.Utilities
{
	public class ReferenceEqualityComparer<T> : IEqualityComparer<T> where T : class
	{
		public static readonly ReferenceEqualityComparer<T> Default;

		public bool Equals(T x, T y)
		{
			return false;
		}

		public int GetHashCode(T obj)
		{
			return 0;
		}
	}
}

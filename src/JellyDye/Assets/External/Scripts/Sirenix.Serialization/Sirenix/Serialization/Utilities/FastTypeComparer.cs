using System;
using System.Collections.Generic;

namespace Sirenix.Serialization.Utilities
{
	public class FastTypeComparer : IEqualityComparer<Type>
	{
		public static readonly FastTypeComparer Instance;

		public bool Equals(Type x, Type y)
		{
			return false;
		}

		public int GetHashCode(Type obj)
		{
			return 0;
		}
	}
}

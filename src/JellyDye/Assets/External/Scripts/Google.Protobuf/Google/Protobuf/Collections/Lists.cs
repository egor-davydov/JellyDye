using System.Collections.Generic;

namespace Google.Protobuf.Collections
{
	public static class Lists
	{
		public static bool Equals<T>(List<T> left, List<T> right)
		{
			return false;
		}

		public static int GetHashCode<T>(List<T> list)
		{
			return 0;
		}
	}
}

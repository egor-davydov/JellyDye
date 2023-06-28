using System;

namespace Sirenix.OdinInspector
{
	public sealed class MultiLinePropertyAttribute : Attribute
	{
		public int Lines;

		public MultiLinePropertyAttribute(int lines = 3)
		{
		}
	}
}

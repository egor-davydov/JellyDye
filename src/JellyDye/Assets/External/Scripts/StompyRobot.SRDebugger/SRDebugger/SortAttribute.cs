using System;

namespace SRDebugger
{
	public class SortAttribute : Attribute
	{
		public readonly int SortPriority;

		public SortAttribute(int priority)
		{
		}
	}
}

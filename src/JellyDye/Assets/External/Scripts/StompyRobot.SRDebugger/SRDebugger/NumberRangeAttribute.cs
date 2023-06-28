using System;

namespace SRDebugger
{
	public class NumberRangeAttribute : Attribute
	{
		public readonly double Max;

		public readonly double Min;

		public NumberRangeAttribute(double min, double max)
		{
		}
	}
}

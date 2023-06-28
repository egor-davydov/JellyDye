using System;

namespace Sirenix.OdinInspector
{
	public sealed class WrapAttribute : Attribute
	{
		public double Min;

		public double Max;

		public WrapAttribute(double min, double max)
		{
		}
	}
}

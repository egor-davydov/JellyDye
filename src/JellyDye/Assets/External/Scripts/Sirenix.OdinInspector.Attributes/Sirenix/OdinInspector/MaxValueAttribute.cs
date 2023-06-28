using System;

namespace Sirenix.OdinInspector
{
	public sealed class MaxValueAttribute : Attribute
	{
		public double MaxValue;

		public string Expression;

		public MaxValueAttribute(double maxValue)
		{
		}

		public MaxValueAttribute(string expression)
		{
		}
	}
}

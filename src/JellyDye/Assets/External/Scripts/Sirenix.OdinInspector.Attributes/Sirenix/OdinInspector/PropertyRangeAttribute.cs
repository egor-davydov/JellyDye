using System;

namespace Sirenix.OdinInspector
{
	public sealed class PropertyRangeAttribute : Attribute
	{
		public double Min;

		public double Max;

		public string MinMember;

		public string MaxMember;

		public PropertyRangeAttribute(double min, double max)
		{
		}

		public PropertyRangeAttribute(string minMember, double max)
		{
		}

		public PropertyRangeAttribute(double min, string maxMember)
		{
		}

		public PropertyRangeAttribute(string minMember, string maxMember)
		{
		}
	}
}

using System;

namespace Sirenix.Serialization
{
	[Obsolete]
	public class CustomFormatterAttribute : Attribute
	{
		public readonly int Priority;

		public CustomFormatterAttribute()
		{
		}

		public CustomFormatterAttribute(int priority = 0)
		{
		}
	}
}

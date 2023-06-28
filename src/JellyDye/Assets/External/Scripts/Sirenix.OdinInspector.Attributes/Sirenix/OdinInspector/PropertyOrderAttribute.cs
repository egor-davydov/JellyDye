using System;

namespace Sirenix.OdinInspector
{
	public class PropertyOrderAttribute : Attribute
	{
		public int Order;

		public PropertyOrderAttribute()
		{
		}

		public PropertyOrderAttribute(int order)
		{
		}
	}
}

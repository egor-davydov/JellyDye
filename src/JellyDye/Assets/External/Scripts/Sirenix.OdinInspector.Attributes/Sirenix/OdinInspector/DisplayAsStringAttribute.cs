using System;

namespace Sirenix.OdinInspector
{
	public sealed class DisplayAsStringAttribute : Attribute
	{
		public bool Overflow;

		public DisplayAsStringAttribute()
		{
		}

		public DisplayAsStringAttribute(bool overflow)
		{
		}
	}
}

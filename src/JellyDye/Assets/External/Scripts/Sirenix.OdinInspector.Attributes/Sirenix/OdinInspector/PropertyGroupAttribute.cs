using System;

namespace Sirenix.OdinInspector
{
	public abstract class PropertyGroupAttribute : Attribute
	{
		public string GroupID;

		public string GroupName;

		public int Order;

		public PropertyGroupAttribute(string groupId, int order)
		{
		}

		public PropertyGroupAttribute(string groupId)
		{
		}

		public PropertyGroupAttribute Combine(PropertyGroupAttribute other)
		{
			return null;
		}

		protected virtual void CombineValuesWith(PropertyGroupAttribute other)
		{
		}
	}
}

using System.Collections.Generic;

namespace Sirenix.OdinInspector
{
	public class ValueDropdownList<T> : List<ValueDropdownItem<T>>
	{
		public void Add(string text, T value)
		{
		}

		public void Add(T value)
		{
		}

		public ValueDropdownList()
		{
			((List<T>)(object)this)._002Ector();
		}
	}
}

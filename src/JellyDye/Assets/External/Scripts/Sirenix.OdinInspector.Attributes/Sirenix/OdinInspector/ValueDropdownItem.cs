namespace Sirenix.OdinInspector
{
	public struct ValueDropdownItem : IValueDropdownItem
	{
		public string Text;

		public object Value;

		public ValueDropdownItem(string text, object value)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private string Sirenix_002EOdinInspector_002EIValueDropdownItem_002EGetText()
		{
			return null;
		}

		private object Sirenix_002EOdinInspector_002EIValueDropdownItem_002EGetValue()
		{
			return null;
		}
	}
	public struct ValueDropdownItem<T> : IValueDropdownItem
	{
		public string Text;

		public T Value;

		public ValueDropdownItem(string text, T value)
		{
		}

		private string Sirenix_002EOdinInspector_002EIValueDropdownItem_002EGetText()
		{
			return null;
		}

		private object Sirenix_002EOdinInspector_002EIValueDropdownItem_002EGetValue()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}

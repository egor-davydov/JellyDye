using System;

namespace Sirenix.OdinInspector
{
	public sealed class DictionaryDrawerSettings : Attribute
	{
		public string KeyLabel;

		public string ValueLabel;

		public DictionaryDisplayOptions DisplayMode;

		public bool IsReadOnly;
	}
}

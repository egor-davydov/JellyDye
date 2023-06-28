using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class CustomContextMenuAttribute : Attribute
	{
		public string MenuItem;

		public string MethodName;

		public CustomContextMenuAttribute(string menuItem, string methodName)
		{
		}
	}
}

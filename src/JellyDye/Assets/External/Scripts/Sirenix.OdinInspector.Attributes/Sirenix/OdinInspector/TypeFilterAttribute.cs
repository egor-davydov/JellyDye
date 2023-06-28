using System;

namespace Sirenix.OdinInspector
{
	public class TypeFilterAttribute : Attribute
	{
		public string MemberName;

		public string DropdownTitle;

		public TypeFilterAttribute(string memberName)
		{
		}
	}
}

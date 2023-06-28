using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class EnableIfAttribute : Attribute
	{
		public string MemberName;

		public object Value;

		public EnableIfAttribute(string memberName)
		{
		}

		public EnableIfAttribute(string memberName, object optionalValue)
		{
		}
	}
}

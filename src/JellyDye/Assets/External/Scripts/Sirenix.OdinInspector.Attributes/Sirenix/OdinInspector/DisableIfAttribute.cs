using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class DisableIfAttribute : Attribute
	{
		public string MemberName;

		public object Value;

		public DisableIfAttribute(string memberName)
		{
		}

		public DisableIfAttribute(string memberName, object optionalValue)
		{
		}
	}
}

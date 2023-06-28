using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class ShowIfAttribute : Attribute
	{
		public string MemberName;

		public bool Animate;

		public object Value;

		public ShowIfAttribute(string memberName, bool animate = true)
		{
		}

		public ShowIfAttribute(string memberName, object optionalValue, bool animate = true)
		{
		}
	}
}

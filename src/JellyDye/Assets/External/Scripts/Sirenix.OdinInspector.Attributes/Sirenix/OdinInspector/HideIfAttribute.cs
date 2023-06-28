using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class HideIfAttribute : Attribute
	{
		public string MemberName;

		public object Value;

		public bool Animate;

		public HideIfAttribute(string memberName, bool animate = true)
		{
		}

		public HideIfAttribute(string memberName, object optionalValue, bool animate = true)
		{
		}
	}
}

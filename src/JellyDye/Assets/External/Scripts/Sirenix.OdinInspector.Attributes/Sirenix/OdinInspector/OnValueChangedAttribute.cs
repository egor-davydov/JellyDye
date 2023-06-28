using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class OnValueChangedAttribute : Attribute
	{
		public string MethodName;

		public bool IncludeChildren;

		public OnValueChangedAttribute(string methodName, bool includeChildren = false)
		{
		}
	}
}

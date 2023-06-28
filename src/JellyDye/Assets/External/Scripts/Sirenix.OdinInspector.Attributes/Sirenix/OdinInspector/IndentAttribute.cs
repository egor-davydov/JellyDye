using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class IndentAttribute : Attribute
	{
		public int IndentLevel;

		public IndentAttribute(int indentLevel = 1)
		{
		}
	}
}

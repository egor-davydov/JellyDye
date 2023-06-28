using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public class LabelTextAttribute : Attribute
	{
		public string Text;

		public LabelTextAttribute(string text)
		{
		}
	}
}

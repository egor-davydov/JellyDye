using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public class LabelWidthAttribute : Attribute
	{
		public float Width;

		public LabelWidthAttribute(float width)
		{
		}
	}
}

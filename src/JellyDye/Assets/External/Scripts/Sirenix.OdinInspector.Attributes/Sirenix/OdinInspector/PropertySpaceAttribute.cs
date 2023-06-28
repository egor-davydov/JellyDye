using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public class PropertySpaceAttribute : Attribute
	{
		public float SpaceBefore;

		public float SpaceAfter;

		public PropertySpaceAttribute()
		{
		}

		public PropertySpaceAttribute(float spaceBefore)
		{
		}

		public PropertySpaceAttribute(float spaceBefore, float spaceAfter)
		{
		}
	}
}

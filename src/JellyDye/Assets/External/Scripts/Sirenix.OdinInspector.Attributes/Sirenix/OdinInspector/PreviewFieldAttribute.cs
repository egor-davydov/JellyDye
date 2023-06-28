using System;

namespace Sirenix.OdinInspector
{
	public class PreviewFieldAttribute : Attribute
	{
		public float Height;

		public ObjectFieldAlignment Alignment;

		public bool AlignmentHasValue;

		public PreviewFieldAttribute()
		{
		}

		public PreviewFieldAttribute(float height)
		{
		}

		public PreviewFieldAttribute(float height, ObjectFieldAlignment alignment)
		{
		}

		public PreviewFieldAttribute(ObjectFieldAlignment alignment)
		{
		}
	}
}

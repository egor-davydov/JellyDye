namespace Sirenix.OdinInspector
{
	public class HorizontalGroupAttribute : PropertyGroupAttribute
	{
		public float Width;

		public float MarginLeft;

		public float MarginRight;

		public float PaddingLeft;

		public float PaddingRight;

		public float MinWidth;

		public float MaxWidth;

		public string Title;

		public float LabelWidth;

		public HorizontalGroupAttribute(string group, float width = 0f, int marginLeft = 0, int marginRight = 0, int order = 0)
			: base(null, 0)
		{
		}

		public HorizontalGroupAttribute(float width = 0f, int marginLeft = 0, int marginRight = 0, int order = 0)
			: base(null, 0)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}
	}
}

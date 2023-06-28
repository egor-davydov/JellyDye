namespace Sirenix.OdinInspector
{
	public class VerticalGroupAttribute : PropertyGroupAttribute
	{
		public float PaddingTop;

		public float PaddingBottom;

		public VerticalGroupAttribute(string groupId, int order = 0)
			: base(null, 0)
		{
		}

		public VerticalGroupAttribute(int order = 0)
			: base(null, 0)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}
	}
}

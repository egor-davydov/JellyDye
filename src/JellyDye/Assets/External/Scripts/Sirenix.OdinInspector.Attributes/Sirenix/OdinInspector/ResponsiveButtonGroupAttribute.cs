namespace Sirenix.OdinInspector
{
	[ShowInInspector]
	[IncludeMyAttributes]
	public class ResponsiveButtonGroupAttribute : PropertyGroupAttribute
	{
		public ButtonSizes DefaultButtonSize;

		public bool UniformLayout;

		public ResponsiveButtonGroupAttribute(string group = "_DefaultResponsiveButtonGroup")
			: base(null, 0)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}
	}
}

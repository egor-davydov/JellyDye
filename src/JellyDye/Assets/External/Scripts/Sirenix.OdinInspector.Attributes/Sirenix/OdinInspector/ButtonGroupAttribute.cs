namespace Sirenix.OdinInspector
{
	[IncludeMyAttributes]
	[ShowInInspector]
	public class ButtonGroupAttribute : PropertyGroupAttribute
	{
		public ButtonGroupAttribute(string group = "_DefaultGroup", int order = 0)
			: base(null, 0)
		{
		}
	}
}

using System;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class PropertyTooltipAttribute : Attribute
	{
		public string Tooltip;

		public PropertyTooltipAttribute(string tooltip)
		{
		}
	}
}

using System;

namespace Sirenix.OdinInspector
{
	public sealed class ToggleAttribute : Attribute
	{
		public string ToggleMemberName;

		public bool CollapseOthersOnExpand;

		public ToggleAttribute(string toggleMemberName)
		{
		}
	}
}

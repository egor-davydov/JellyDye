using System;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	public sealed class ToggleGroupAttribute : PropertyGroupAttribute
	{
		public string ToggleGroupTitle;

		public bool CollapseOthersOnExpand;

		public string ToggleMemberName => null;

		[Obsolete]
		public string TitleStringMemberName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public ToggleGroupAttribute(string toggleMemberName, int order = 0, string groupTitle = null)
			: base(null, 0)
		{
		}

		public ToggleGroupAttribute(string toggleMemberName, string groupTitle)
			: base(null, 0)
		{
		}

		[Obsolete]
		public ToggleGroupAttribute(string toggleMemberName, int order, string groupTitle, string titleStringMemberName)
			: base(null, 0)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}
	}
}

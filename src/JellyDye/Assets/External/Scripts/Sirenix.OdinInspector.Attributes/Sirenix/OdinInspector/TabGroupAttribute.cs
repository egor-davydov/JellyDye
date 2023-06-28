using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector.Internal;

namespace Sirenix.OdinInspector
{
	public class TabGroupAttribute : PropertyGroupAttribute, ISubGroupProviderAttribute
	{
		private class TabSubGroupAttribute : PropertyGroupAttribute
		{
			public TabSubGroupAttribute(string groupId, int order)
				: base(null, 0)
			{
			}
		}

		public const string DEFAULT_NAME = "_DefaultTabGroup";

		public string TabName;

		public bool UseFixedHeight;

		public bool Paddingless;

		public bool HideTabGroupIfTabGroupOnlyHasOneTab;

		public List<string> Tabs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TabGroupAttribute(string tab, bool useFixedHeight = false, int order = 0)
			: base(null, 0)
		{
		}

		public TabGroupAttribute(string group, string tab, bool useFixedHeight = false, int order = 0)
			: base(null, 0)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		private IList<PropertyGroupAttribute> Sirenix_002EOdinInspector_002EInternal_002EISubGroupProviderAttribute_002EGetSubGroupAttributes()
		{
			return null;
		}

		private string Sirenix_002EOdinInspector_002EInternal_002EISubGroupProviderAttribute_002ERepathMemberAttribute(PropertyGroupAttribute attr)
		{
			return null;
		}
	}
}

using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	public class FoldoutGroupAttribute : PropertyGroupAttribute
	{
		public bool Expanded;

		public bool HasDefinedExpanded
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public FoldoutGroupAttribute(string groupName, int order = 0)
			: base(null, 0)
		{
		}

		public FoldoutGroupAttribute(string groupName, bool expanded, int order = 0)
			: base(null, 0)
		{
		}

		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}
	}
}

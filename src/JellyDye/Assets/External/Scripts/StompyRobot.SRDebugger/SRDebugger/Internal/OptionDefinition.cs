using System.Runtime.CompilerServices;
using SRF.Helpers;

namespace SRDebugger.Internal
{
	public class OptionDefinition
	{
		public string Name
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

		public string Category
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

		public int SortPriority
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public MethodReference Method
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

		public PropertyReference Property
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

		private OptionDefinition(string name, string category, int sortPriority)
		{
		}

		public OptionDefinition(string name, string category, int sortPriority, MethodReference method)
		{
		}

		public OptionDefinition(string name, string category, int sortPriority, PropertyReference property)
		{
		}
	}
}

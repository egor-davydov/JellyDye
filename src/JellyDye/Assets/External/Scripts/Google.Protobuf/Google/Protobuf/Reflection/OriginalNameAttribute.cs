using System;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public class OriginalNameAttribute : Attribute
	{
		public string Name
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

		public bool PreferredAlias
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public OriginalNameAttribute(string name)
		{
		}
	}
}

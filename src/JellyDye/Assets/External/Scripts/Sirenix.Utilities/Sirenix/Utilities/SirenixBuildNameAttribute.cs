using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Utilities
{
	public class SirenixBuildNameAttribute : Attribute
	{
		public string BuildName
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

		public SirenixBuildNameAttribute(string buildName)
		{
		}
	}
}

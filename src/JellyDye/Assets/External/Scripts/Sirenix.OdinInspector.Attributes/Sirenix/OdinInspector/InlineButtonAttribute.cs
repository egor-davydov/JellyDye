using System;
using System.Runtime.CompilerServices;

namespace Sirenix.OdinInspector
{
	[DontApplyToListElements]
	public sealed class InlineButtonAttribute : Attribute
	{
		public string MemberMethod
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

		public string Label
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

		public InlineButtonAttribute(string memberMethod, string label = null)
		{
		}
	}
}

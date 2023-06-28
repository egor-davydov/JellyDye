using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class RegisterFormatterAttribute : Attribute
	{
		public Type FormatterType
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

		public int Priority
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

		public RegisterFormatterAttribute(Type formatterType, int priority = 0)
		{
		}
	}
}

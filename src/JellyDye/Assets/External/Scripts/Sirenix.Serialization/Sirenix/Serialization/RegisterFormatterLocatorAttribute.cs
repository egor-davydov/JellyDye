using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class RegisterFormatterLocatorAttribute : Attribute
	{
		public Type FormatterLocatorType
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

		public RegisterFormatterLocatorAttribute(Type formatterLocatorType, int priority = 0)
		{
		}
	}
}

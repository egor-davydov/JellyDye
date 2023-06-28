using System;
using System.Runtime.CompilerServices;

namespace Sirenix.Serialization
{
	public class PreviouslySerializedAsAttribute : Attribute
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

		public PreviouslySerializedAsAttribute(string name)
		{
		}
	}
}

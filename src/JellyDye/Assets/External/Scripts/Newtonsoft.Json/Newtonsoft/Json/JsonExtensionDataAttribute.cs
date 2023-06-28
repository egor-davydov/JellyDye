using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	public class JsonExtensionDataAttribute : Attribute
	{
		public bool WriteData
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public bool ReadData
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}
	}
}

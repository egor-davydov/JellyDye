using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	internal class TypeInformation
	{
		public Type Type
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public PrimitiveTypeCode TypeCode
		{
			[CompilerGenerated]
			get
			{
				return default(PrimitiveTypeCode);
			}
		}

		public TypeInformation(Type type, PrimitiveTypeCode typeCode)
		{
		}
	}
}

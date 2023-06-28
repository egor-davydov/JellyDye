using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	public class JsonPrimitiveContract : JsonContract
	{
		private static readonly Dictionary<Type, ReadType> ReadTypeMap;

		internal PrimitiveTypeCode TypeCode
		{
			[CompilerGenerated]
			get
			{
				return default(PrimitiveTypeCode);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public JsonPrimitiveContract(Type underlyingType)
			: base(null)
		{
		}
	}
}

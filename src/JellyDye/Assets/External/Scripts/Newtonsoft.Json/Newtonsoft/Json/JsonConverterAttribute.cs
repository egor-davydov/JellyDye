using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	public sealed class JsonConverterAttribute : Attribute
	{
		private readonly Type _converterType;

		public Type ConverterType => null;

		public object[] ConverterParameters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public JsonConverterAttribute(Type converterType)
		{
		}
	}
}

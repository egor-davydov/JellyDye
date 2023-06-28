using System;

namespace Sirenix.Serialization
{
	public sealed class BindTypeNameToTypeAttribute : Attribute
	{
		internal readonly Type NewType;

		internal readonly string OldTypeName;

		public BindTypeNameToTypeAttribute(string oldFullTypeName, Type newType)
		{
		}
	}
}

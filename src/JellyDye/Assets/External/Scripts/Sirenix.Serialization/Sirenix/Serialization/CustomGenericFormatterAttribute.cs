using System;

namespace Sirenix.Serialization
{
	[Obsolete]
	public class CustomGenericFormatterAttribute : CustomFormatterAttribute
	{
		public readonly Type SerializedGenericTypeDefinition;

		public CustomGenericFormatterAttribute(Type serializedGenericTypeDefinition, int priority = 0)
		{
		}
	}
}

using System;

namespace Sirenix.Serialization
{
	public sealed class RegisterDictionaryKeyPathProviderAttribute : Attribute
	{
		public readonly Type ProviderType;

		public RegisterDictionaryKeyPathProviderAttribute(Type providerType)
		{
		}
	}
}

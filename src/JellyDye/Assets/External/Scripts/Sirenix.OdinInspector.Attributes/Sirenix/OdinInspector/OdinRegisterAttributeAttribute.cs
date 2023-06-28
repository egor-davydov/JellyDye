using System;

namespace Sirenix.OdinInspector
{
	public class OdinRegisterAttributeAttribute : Attribute
	{
		public Type AttributeType;

		public string Categories;

		public string Description;

		public string DocumentationUrl;

		public OdinRegisterAttributeAttribute(Type attributeType, string category, string description)
		{
		}

		public OdinRegisterAttributeAttribute(Type attributeType, string category, string description, string url)
		{
		}
	}
}

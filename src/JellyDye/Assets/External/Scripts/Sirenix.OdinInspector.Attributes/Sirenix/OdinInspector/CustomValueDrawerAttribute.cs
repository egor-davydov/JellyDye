using System;

namespace Sirenix.OdinInspector
{
	public class CustomValueDrawerAttribute : Attribute
	{
		public string MethodName;

		public CustomValueDrawerAttribute(string methodName)
		{
		}
	}
}

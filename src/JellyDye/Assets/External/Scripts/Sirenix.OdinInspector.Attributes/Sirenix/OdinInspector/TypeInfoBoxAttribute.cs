using System;

namespace Sirenix.OdinInspector
{
	public class TypeInfoBoxAttribute : Attribute
	{
		public string Message;

		public TypeInfoBoxAttribute(string message)
		{
		}
	}
}

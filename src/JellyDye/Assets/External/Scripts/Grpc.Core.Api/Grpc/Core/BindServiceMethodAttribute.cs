using System;

namespace Grpc.Core
{
	public class BindServiceMethodAttribute : Attribute
	{
		public BindServiceMethodAttribute(Type bindType, string bindMethodName)
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace Grpc.Core.Internal
{
	internal sealed class MonoPInvokeCallbackAttribute : Attribute
	{
		private Type Type
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public MonoPInvokeCallbackAttribute(Type type)
		{
		}
	}
}

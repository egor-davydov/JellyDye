using System;
using System.Runtime.CompilerServices;

namespace Firebase
{
	public sealed class InitializationException : Exception
	{
		private InitResult InitResult
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public InitializationException(InitResult result, string message)
		{
		}

		public InitializationException(InitResult result, string message, Exception inner)
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace Unity.Services.Core.Internal
{
	internal class HashException : Exception
	{
		public int Hash
		{
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		public HashException(int hash, string message)
		{
		}

		public HashException(int hash, string message, Exception inner)
		{
		}
	}
}

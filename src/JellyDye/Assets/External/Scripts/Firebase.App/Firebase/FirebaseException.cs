using System;
using System.Runtime.CompilerServices;

namespace Firebase
{
	public sealed class FirebaseException : Exception
	{
		private int ErrorCode
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public FirebaseException(int errorCode, string message)
		{
		}
	}
}

using System;

namespace Polly
{
	public abstract class Policy : PolicyBase
	{
		public static PolicyBuilder Handle<TException>() where TException : Exception
		{
			return null;
		}
	}
}

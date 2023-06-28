using System;

namespace Polly
{
	public abstract class ExecutionRejectedException : Exception
	{
		protected ExecutionRejectedException(string message)
		{
		}

		protected ExecutionRejectedException(string message, Exception inner)
		{
		}
	}
}

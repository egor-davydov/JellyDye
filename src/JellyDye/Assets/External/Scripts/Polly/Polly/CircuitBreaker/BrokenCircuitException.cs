using System;

namespace Polly.CircuitBreaker
{
	public class BrokenCircuitException : ExecutionRejectedException
	{
		public BrokenCircuitException(string message)
			: base(null)
		{
		}

		public BrokenCircuitException(string message, Exception inner)
			: base(null)
		{
		}
	}
	public class BrokenCircuitException<TResult> : BrokenCircuitException
	{
		private readonly TResult result;

		public BrokenCircuitException(string message, TResult result)
			: base(null)
		{
		}
	}
}

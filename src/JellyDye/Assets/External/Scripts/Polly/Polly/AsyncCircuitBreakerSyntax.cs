using System;
using Polly.CircuitBreaker;

namespace Polly
{
	public static class AsyncCircuitBreakerSyntax
	{
		public static AsyncCircuitBreakerPolicy CircuitBreakerAsync(this PolicyBuilder policyBuilder, int exceptionsAllowedBeforeBreaking, TimeSpan durationOfBreak, Action<Exception, TimeSpan> onBreak, Action onReset, Action onHalfOpen)
		{
			return null;
		}

		public static AsyncCircuitBreakerPolicy CircuitBreakerAsync(this PolicyBuilder policyBuilder, int exceptionsAllowedBeforeBreaking, TimeSpan durationOfBreak, Action<Exception, TimeSpan, Context> onBreak, Action<Context> onReset, Action onHalfOpen)
		{
			return null;
		}

		public static AsyncCircuitBreakerPolicy CircuitBreakerAsync(this PolicyBuilder policyBuilder, int exceptionsAllowedBeforeBreaking, TimeSpan durationOfBreak, Action<Exception, CircuitState, TimeSpan, Context> onBreak, Action<Context> onReset, Action onHalfOpen)
		{
			return null;
		}
	}
}

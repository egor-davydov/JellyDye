using System;
using System.Threading.Tasks;
using Polly.Retry;

namespace Polly
{
	public static class AsyncRetrySyntax
	{
		public static AsyncRetryPolicy WaitAndRetryForeverAsync(this PolicyBuilder policyBuilder, Func<int, Context, TimeSpan> sleepDurationProvider, Action<Exception, int, TimeSpan, Context> onRetry)
		{
			return null;
		}

		public static AsyncRetryPolicy WaitAndRetryForeverAsync(this PolicyBuilder policyBuilder, Func<int, Context, TimeSpan> sleepDurationProvider, Func<Exception, int, TimeSpan, Context, Task> onRetryAsync)
		{
			return null;
		}

		public static AsyncRetryPolicy WaitAndRetryForeverAsync(this PolicyBuilder policyBuilder, Func<int, Exception, Context, TimeSpan> sleepDurationProvider, Func<Exception, int, TimeSpan, Context, Task> onRetryAsync)
		{
			return null;
		}
	}
}

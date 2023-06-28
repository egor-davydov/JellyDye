using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Polly.Retry
{
	public class AsyncRetryPolicy : AsyncPolicy
	{
		private readonly Func<Exception, TimeSpan, int, Context, Task> _onRetryAsync;

		private readonly int _permittedRetryCount;

		private readonly IEnumerable<TimeSpan> _sleepDurationsEnumerable;

		private readonly Func<int, Exception, Context, TimeSpan> _sleepDurationProvider;

		internal AsyncRetryPolicy(PolicyBuilder policyBuilder, Func<Exception, TimeSpan, int, Context, Task> onRetryAsync, int permittedRetryCount = int.MaxValue, IEnumerable<TimeSpan> sleepDurationsEnumerable = null, Func<int, Exception, Context, TimeSpan> sleepDurationProvider = null)
			: base((ExceptionPredicates)null)
		{
		}

		[DebuggerStepThrough]
		protected override Task<TResult> ImplementationAsync<TResult>(Func<Context, CancellationToken, Task<TResult>> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext)
		{
			return null;
		}
	}
}

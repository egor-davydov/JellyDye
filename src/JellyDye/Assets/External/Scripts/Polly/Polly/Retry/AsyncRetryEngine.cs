using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Polly.Retry
{
	internal static class AsyncRetryEngine
	{
		internal static Task<TResult> ImplementationAsync<TResult>(Func<Context, CancellationToken, Task<TResult>> action, Context context, CancellationToken cancellationToken, ExceptionPredicates shouldRetryExceptionPredicates, ResultPredicates<TResult> shouldRetryResultPredicates, Func<DelegateResult<TResult>, TimeSpan, int, Context, Task> onRetryAsync, int permittedRetryCount = int.MaxValue, IEnumerable<TimeSpan> sleepDurationsEnumerable = null, Func<int, DelegateResult<TResult>, Context, TimeSpan> sleepDurationProvider = null, bool continueOnCapturedContext = false)
		{
			return null;
		}
	}
}

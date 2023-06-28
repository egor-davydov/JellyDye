using System;
using System.Threading;
using System.Threading.Tasks;

namespace Polly.CircuitBreaker
{
	internal class AsyncCircuitBreakerEngine
	{
		internal static Task<TResult> ImplementationAsync<TResult>(Func<Context, CancellationToken, Task<TResult>> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext, ExceptionPredicates shouldHandleExceptionPredicates, ResultPredicates<TResult> shouldHandleResultPredicates, ICircuitController<TResult> breakerController)
		{
			return null;
		}
	}
}

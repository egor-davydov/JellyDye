using System;
using System.Threading;
using System.Threading.Tasks;
using Polly.Utilities;

namespace Polly.CircuitBreaker
{
	public class AsyncCircuitBreakerPolicy : AsyncPolicy
	{
		internal readonly ICircuitController<EmptyStruct> _breakerController;

		internal AsyncCircuitBreakerPolicy(PolicyBuilder policyBuilder, ICircuitController<EmptyStruct> breakerController)
			: base((ExceptionPredicates)null)
		{
		}

		protected override Task<TResult> ImplementationAsync<TResult>(Func<Context, CancellationToken, Task<TResult>> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext)
		{
			return null;
		}
	}
}

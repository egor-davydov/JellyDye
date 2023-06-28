using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Polly.Wrap;

namespace Polly
{
	public abstract class AsyncPolicy : PolicyBase, IAsyncPolicy
	{
		internal AsyncPolicy(ExceptionPredicates exceptionPredicates)
			: base((ExceptionPredicates)null)
		{
		}

		protected AsyncPolicy(PolicyBuilder policyBuilder = null)
			: base((ExceptionPredicates)null)
		{
		}

		[DebuggerStepThrough]
		public Task ExecuteAsync(Func<Context, CancellationToken, Task> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext)
		{
			return null;
		}

		[DebuggerStepThrough]
		public Task<TResult> ExecuteAsync<TResult>(Func<Context, CancellationToken, Task<TResult>> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext)
		{
			return null;
		}

		[DebuggerStepThrough]
		public Task<PolicyResult> ExecuteAndCaptureAsync(Func<Context, CancellationToken, Task> action, Context context, CancellationToken cancellationToken)
		{
			return null;
		}

		[DebuggerStepThrough]
		public Task<PolicyResult> ExecuteAndCaptureAsync(Func<Context, CancellationToken, Task> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext)
		{
			return null;
		}

		protected virtual Task ImplementationAsync(Func<Context, CancellationToken, Task> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext)
		{
			return null;
		}

		protected abstract Task<TResult> ImplementationAsync<TResult>(Func<Context, CancellationToken, Task<TResult>> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext);

		public AsyncPolicyWrap WrapAsync(IAsyncPolicy innerPolicy)
		{
			return null;
		}
	}
}

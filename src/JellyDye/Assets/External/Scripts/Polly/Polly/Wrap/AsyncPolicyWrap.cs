using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Polly.Wrap
{
	public class AsyncPolicyWrap : AsyncPolicy
	{
		private IAsyncPolicy _outer;

		private IAsyncPolicy _inner;

		internal override void SetPolicyContext(Context executionContext, out string priorPolicyWrapKey, out string priorPolicyKey)
		{
			priorPolicyWrapKey = null;
			priorPolicyKey = null;
		}

		internal AsyncPolicyWrap(AsyncPolicy outer, IAsyncPolicy inner)
			: base((ExceptionPredicates)null)
		{
		}

		[DebuggerStepThrough]
		protected override Task ImplementationAsync(Func<Context, CancellationToken, Task> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext)
		{
			return null;
		}

		[DebuggerStepThrough]
		protected override Task<TResult> ImplementationAsync<TResult>(Func<Context, CancellationToken, Task<TResult>> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext)
		{
			return null;
		}
	}
}

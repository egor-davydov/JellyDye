using System;
using System.Threading;
using System.Threading.Tasks;

namespace Polly.Wrap
{
	internal static class AsyncPolicyWrapEngine
	{
		internal static Task<TResult> ImplementationAsync<TResult>(Func<Context, CancellationToken, Task<TResult>> func, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext, IAsyncPolicy outerPolicy, IAsyncPolicy innerPolicy)
		{
			return null;
		}

		internal static Task ImplementationAsync(Func<Context, CancellationToken, Task> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext, IAsyncPolicy outerPolicy, IAsyncPolicy innerPolicy)
		{
			return null;
		}
	}
}

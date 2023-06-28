using System;
using System.Threading;
using System.Threading.Tasks;

namespace Polly
{
	public interface IAsyncPolicy
	{
		Task ExecuteAsync(Func<Context, CancellationToken, Task> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext);

		Task<TResult> ExecuteAsync<TResult>(Func<Context, CancellationToken, Task<TResult>> action, Context context, CancellationToken cancellationToken, bool continueOnCapturedContext);
	}
}

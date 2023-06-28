using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Grpc.Core
{
	public sealed class AsyncUnaryCall<TResponse> : IDisposable
	{
		private readonly Task<TResponse> responseAsync;

		private readonly AsyncCallState callState;

		public AsyncUnaryCall(Task<TResponse> responseAsync, Func<object, Task<Metadata>> responseHeadersAsync, Func<object, Status> getStatusFunc, Func<object, Metadata> getTrailersFunc, Action<object> disposeAction, object state)
		{
		}

		public TaskAwaiter<TResponse> GetAwaiter()
		{
			return default(TaskAwaiter<TResponse>);
		}

		public void Dispose()
		{
		}
	}
}

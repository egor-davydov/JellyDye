using System;
using System.Threading.Tasks;

namespace Grpc.Core
{
	internal struct AsyncCallState
	{
		private readonly object responseHeadersAsync;

		private readonly object getStatusFunc;

		private readonly object getTrailersFunc;

		private readonly object disposeAction;

		private readonly object callbackState;

		internal AsyncCallState(Func<object, Task<Metadata>> responseHeadersAsync, Func<object, Status> getStatusFunc, Func<object, Metadata> getTrailersFunc, Action<object> disposeAction, object callbackState)
		{
		}

		internal void Dispose()
		{
		}
	}
}

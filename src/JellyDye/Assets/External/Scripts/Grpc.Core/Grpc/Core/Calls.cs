using System;
using System.Threading.Tasks;

namespace Grpc.Core
{
	public static class Calls
	{
		private static class Callbacks<TRequest, TResponse>
		{
			internal static readonly Func<object, Task<Metadata>> GetHeaders;

			internal static readonly Func<object, Status> GetStatus;

			internal static readonly Func<object, Metadata> GetTrailers;

			internal static readonly Action<object> Cancel;
		}

		public static TResponse BlockingUnaryCall<TRequest, TResponse>(CallInvocationDetails<TRequest, TResponse> call, TRequest req) where TRequest : class where TResponse : class
		{
			return null;
		}

		public static AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(CallInvocationDetails<TRequest, TResponse> call, TRequest req) where TRequest : class where TResponse : class
		{
			return null;
		}
	}
}

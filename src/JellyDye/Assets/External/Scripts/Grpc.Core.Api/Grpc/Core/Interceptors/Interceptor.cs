namespace Grpc.Core.Interceptors
{
	public abstract class Interceptor
	{
		public delegate TResponse BlockingUnaryCallContinuation<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context) where TRequest : class where TResponse : class;

		public delegate AsyncUnaryCall<TResponse> AsyncUnaryCallContinuation<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context) where TRequest : class where TResponse : class;

		public virtual TResponse BlockingUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, BlockingUnaryCallContinuation<TRequest, TResponse> continuation) where TRequest : class where TResponse : class
		{
			return null;
		}

		public virtual AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, AsyncUnaryCallContinuation<TRequest, TResponse> continuation) where TRequest : class where TResponse : class
		{
			return null;
		}
	}
}

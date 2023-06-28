namespace Grpc.Core
{
	public abstract class CallInvoker
	{
		public abstract TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) where TRequest : class where TResponse : class;

		public abstract AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request) where TRequest : class where TResponse : class;
	}
}

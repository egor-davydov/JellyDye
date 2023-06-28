namespace Grpc.Core
{
	public class DefaultCallInvoker : CallInvoker
	{
		private readonly Channel channel;

		public DefaultCallInvoker(Channel channel)
		{
		}

		public override TResponse BlockingUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			return null;
		}

		public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
		{
			return null;
		}

		protected virtual CallInvocationDetails<TRequest, TResponse> CreateCall<TRequest, TResponse>(Method<TRequest, TResponse> method, string host, CallOptions options) where TRequest : class where TResponse : class
		{
			return default(CallInvocationDetails<TRequest, TResponse>);
		}
	}
}

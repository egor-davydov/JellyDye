namespace Grpc.Core.Interceptors
{
	internal class InterceptingCallInvoker : CallInvoker
	{
		private readonly CallInvoker invoker;

		private readonly Interceptor interceptor;

		public InterceptingCallInvoker(CallInvoker invoker, Interceptor interceptor)
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
	}
}

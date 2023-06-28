namespace Grpc.Core.Internal
{
	internal class UnimplementedCallInvoker : CallInvoker
	{
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

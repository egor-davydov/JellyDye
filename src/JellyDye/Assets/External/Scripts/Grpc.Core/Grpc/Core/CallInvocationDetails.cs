namespace Grpc.Core
{
	public struct CallInvocationDetails<TRequest, TResponse>
	{
		private readonly Channel channel;

		private readonly string method;

		private readonly string host;

		private readonly Marshaller<TRequest> requestMarshaller;

		private readonly Marshaller<TResponse> responseMarshaller;

		private CallOptions options;

		public Channel Channel => null;

		public string Method => null;

		public string Host => null;

		public Marshaller<TRequest> RequestMarshaller => null;

		public Marshaller<TResponse> ResponseMarshaller => null;

		public CallOptions Options => default(CallOptions);

		public CallInvocationDetails(Channel channel, Method<TRequest, TResponse> method, string host, CallOptions options)
		{
		}

		public CallInvocationDetails(Channel channel, string method, string host, Marshaller<TRequest> requestMarshaller, Marshaller<TResponse> responseMarshaller, CallOptions options)
		{
		}

		public CallInvocationDetails<TRequest, TResponse> WithOptions(CallOptions options)
		{
			return default(CallInvocationDetails<TRequest, TResponse>);
		}
	}
}

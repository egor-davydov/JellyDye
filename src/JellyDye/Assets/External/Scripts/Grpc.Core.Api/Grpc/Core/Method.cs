namespace Grpc.Core
{
	public class Method<TRequest, TResponse> : IMethod
	{
		private readonly MethodType type;

		private readonly string serviceName;

		private readonly string name;

		private readonly Marshaller<TRequest> requestMarshaller;

		private readonly Marshaller<TResponse> responseMarshaller;

		private readonly string fullName;

		public Marshaller<TRequest> RequestMarshaller => null;

		public Marshaller<TResponse> ResponseMarshaller => null;

		public string FullName => null;

		public Method(MethodType type, string serviceName, string name, Marshaller<TRequest> requestMarshaller, Marshaller<TResponse> responseMarshaller)
		{
		}

		internal static string GetFullName(string serviceName, string methodName)
		{
			return null;
		}
	}
}

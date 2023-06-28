using System.Runtime.CompilerServices;

namespace Grpc.Core.Interceptors
{
	public struct ClientInterceptorContext<TRequest, TResponse> where TRequest : class where TResponse : class
	{
		public Method<TRequest, TResponse> Method
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Host
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public CallOptions Options
		{
			[CompilerGenerated]
			get
			{
				return default(CallOptions);
			}
		}

		public ClientInterceptorContext(Method<TRequest, TResponse> method, string host, CallOptions options)
		{
		}
	}
}

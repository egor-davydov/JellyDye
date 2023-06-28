using System;
using Grpc.Core.Interceptors;

namespace Grpc.Core
{
	public abstract class ClientBase<T> : ClientBase where T : ClientBase<T>
	{
		protected ClientBase()
		{
		}

		protected ClientBase(ClientBaseConfiguration configuration)
		{
		}

		public ClientBase(ChannelBase channel)
		{
		}

		public ClientBase(CallInvoker callInvoker)
		{
		}

		protected abstract T NewInstance(ClientBaseConfiguration configuration);
	}
	public abstract class ClientBase
	{
		protected internal class ClientBaseConfiguration
		{
			private class ClientBaseConfigurationInterceptor : Interceptor
			{
				private readonly Func<IMethod, string, CallOptions, ClientBaseConfigurationInfo> interceptor;

				public ClientBaseConfigurationInterceptor(Func<IMethod, string, CallOptions, ClientBaseConfigurationInfo> interceptor)
				{
				}

				private ClientInterceptorContext<TRequest, TResponse> GetNewContext<TRequest, TResponse>(ClientInterceptorContext<TRequest, TResponse> context) where TRequest : class where TResponse : class
				{
					return default(ClientInterceptorContext<TRequest, TResponse>);
				}

				public override TResponse BlockingUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
				{
					return null;
				}

				public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
				{
					return null;
				}
			}

			internal struct ClientBaseConfigurationInfo
			{
				internal readonly string Host;

				internal readonly CallOptions CallOptions;

				internal ClientBaseConfigurationInfo(string host, CallOptions callOptions)
				{
				}
			}

			private readonly CallInvoker undecoratedCallInvoker;

			private readonly string host;

			internal ClientBaseConfiguration(CallInvoker undecoratedCallInvoker, string host)
			{
			}

			internal CallInvoker CreateDecoratedCallInvoker()
			{
				return null;
			}
		}

		private readonly ClientBaseConfiguration configuration;

		private readonly CallInvoker callInvoker;

		protected CallInvoker CallInvoker => null;

		protected ClientBase()
		{
		}

		protected ClientBase(ClientBaseConfiguration configuration)
		{
		}

		public ClientBase(ChannelBase channel)
		{
		}

		public ClientBase(CallInvoker callInvoker)
		{
		}
	}
}

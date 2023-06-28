using System;
using System.Collections.Generic;

namespace Grpc.Core
{
	public class ServerServiceDefinition
	{
		public class Builder
		{
			private readonly Dictionary<string, object> duplicateDetector;

			private readonly List<Action<ServiceBinderBase>> addMethodActions;

			public Builder AddMethod<TRequest, TResponse>(Method<TRequest, TResponse> method, UnaryServerMethod<TRequest, TResponse> handler) where TRequest : class where TResponse : class
			{
				return null;
			}

			public ServerServiceDefinition Build()
			{
				return null;
			}
		}

		private readonly IReadOnlyList<Action<ServiceBinderBase>> addMethodActions;

		internal ServerServiceDefinition(List<Action<ServiceBinderBase>> addMethodActions)
		{
		}

		public static Builder CreateBuilder()
		{
			return null;
		}
	}
}

using System;

namespace Grpc.Core
{
	public class RpcException : Exception
	{
		private readonly Status status;

		private readonly Metadata trailers;

		public Status Status => default(Status);

		public RpcException(Status status)
		{
		}

		public RpcException(Status status, Metadata trailers)
		{
		}

		public RpcException(Status status, Metadata trailers, string message)
		{
		}
	}
}

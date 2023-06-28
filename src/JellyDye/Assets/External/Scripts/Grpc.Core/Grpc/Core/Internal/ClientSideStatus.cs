namespace Grpc.Core.Internal
{
	internal struct ClientSideStatus
	{
		private readonly Status status;

		private readonly Metadata trailers;

		public Status Status => default(Status);

		public Metadata Trailers => null;

		public ClientSideStatus(Status status, Metadata trailers)
		{
		}
	}
}

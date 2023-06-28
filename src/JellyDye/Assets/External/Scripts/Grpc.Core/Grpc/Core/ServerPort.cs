namespace Grpc.Core
{
	public class ServerPort
	{
		public const int PickUnused = 0;

		private readonly string host;

		private readonly int port;

		private readonly ServerCredentials credentials;

		private readonly int boundPort;
	}
}

namespace Grpc.Core
{
	public abstract class ServerCredentials
	{
		private sealed class InsecureServerCredentialsImpl : ServerCredentials
		{
		}

		private static readonly ServerCredentials InsecureInstance;
	}
}

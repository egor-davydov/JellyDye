namespace Grpc.Core.Internal
{
	internal class DefaultCallCredentialsConfigurator : CallCredentialsConfiguratorBase
	{
		private CallCredentialsSafeHandle nativeCredentials;

		public CallCredentialsSafeHandle NativeCredentials => null;
	}
}

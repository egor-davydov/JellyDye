namespace Grpc.Core
{
	public abstract class CallCredentials
	{
		public abstract void InternalPopulateConfiguration(CallCredentialsConfiguratorBase configurator, object state);
	}
}

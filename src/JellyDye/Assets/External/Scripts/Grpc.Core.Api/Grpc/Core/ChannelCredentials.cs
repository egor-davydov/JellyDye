namespace Grpc.Core
{
	public abstract class ChannelCredentials
	{
		private sealed class InsecureCredentials : ChannelCredentials
		{
			public override void InternalPopulateConfiguration(ChannelCredentialsConfiguratorBase configurator, object state)
			{
			}
		}

		private static readonly ChannelCredentials InsecureInstance;

		public static ChannelCredentials Insecure => null;

		public ChannelCredentials()
		{
		}

		public abstract void InternalPopulateConfiguration(ChannelCredentialsConfiguratorBase configurator, object state);
	}
}

namespace Grpc.Core
{
	public sealed class SslCredentials : ChannelCredentials
	{
		private readonly string rootCertificates;

		private readonly KeyCertificatePair keyCertificatePair;

		private readonly VerifyPeerCallback verifyPeerCallback;

		public SslCredentials()
		{
		}

		public SslCredentials(string rootCertificates, KeyCertificatePair keyCertificatePair, VerifyPeerCallback verifyPeerCallback)
		{
		}

		public override void InternalPopulateConfiguration(ChannelCredentialsConfiguratorBase configurator, object state)
		{
		}
	}
}

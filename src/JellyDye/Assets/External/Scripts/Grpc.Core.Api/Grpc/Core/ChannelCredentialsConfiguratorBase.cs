namespace Grpc.Core
{
	public abstract class ChannelCredentialsConfiguratorBase
	{
		public abstract void SetInsecureCredentials(object state);

		public abstract void SetSslCredentials(object state, string rootCertificates, KeyCertificatePair keyCertificatePair, VerifyPeerCallback verifyPeerCallback);
	}
}

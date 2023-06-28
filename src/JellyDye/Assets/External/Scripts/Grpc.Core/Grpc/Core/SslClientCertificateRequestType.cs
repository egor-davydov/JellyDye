namespace Grpc.Core
{
	public enum SslClientCertificateRequestType
	{
		DontRequest = 0,
		RequestButDontVerify = 1,
		RequestAndVerify = 2,
		RequestAndRequireButDontVerify = 3,
		RequestAndRequireAndVerify = 4
	}
}

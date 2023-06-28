using System;

namespace Grpc.Core.Internal
{
	internal class ChannelCredentialsSafeHandle : SafeHandleZeroIsInvalid
	{
		private static readonly NativeMethods Native;

		private ChannelCredentialsSafeHandle()
		{
		}

		public static ChannelCredentialsSafeHandle CreateSslCredentials(string pemRootCerts, KeyCertificatePair keyCertPair, IntPtr verifyPeerCallbackTag)
		{
			return null;
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class DefaultChannelCredentialsConfigurator : ChannelCredentialsConfiguratorBase
	{
		private class VerifyPeerCallbackRegistration
		{
			private readonly VerifyPeerCallback verifyPeerCallback;

			private readonly NativeCallbackRegistration callbackRegistration;

			public NativeCallbackRegistration CallbackRegistration => null;

			public VerifyPeerCallbackRegistration(VerifyPeerCallback verifyPeerCallback)
			{
			}

			private int HandleUniversalCallback(IntPtr arg0, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5)
			{
				return 0;
			}

			private int VerifyPeerCallbackHandler(IntPtr targetName, IntPtr peerPem, bool isDestroy)
			{
				return 0;
			}
		}

		private static readonly ILogger Logger;

		private static readonly ConditionalWeakTable<ChannelCredentials, Lazy<ChannelCredentialsSafeHandle>> CachedNativeCredentials;

		private static readonly object StaticLock;

		private bool configured;

		private ChannelCredentialsSafeHandle nativeCredentials;

		public ChannelCredentialsSafeHandle NativeCredentials => null;

		public override void SetInsecureCredentials(object state)
		{
		}

		public override void SetSslCredentials(object state, string rootCertificates, KeyCertificatePair keyCertificatePair, VerifyPeerCallback verifyPeerCallback)
		{
		}

		private ChannelCredentialsSafeHandle CreateNativeSslCredentials(string rootCertificates, KeyCertificatePair keyCertificatePair, VerifyPeerCallback verifyPeerCallback)
		{
			return null;
		}

		private ChannelCredentialsSafeHandle GetOrCreateNativeCredentials(ChannelCredentials key, Func<ChannelCredentialsSafeHandle> nativeCredentialsFactory)
		{
			return null;
		}
	}
}

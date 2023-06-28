using System;
using System.Runtime.CompilerServices;

namespace Firebase.Messaging
{
	public sealed class FirebaseMessaging
	{
		internal class Listener : IDisposable
		{
			internal delegate int MessageReceivedDelegate(IntPtr message);

			internal delegate void TokenReceivedDelegate(string token);

			private MessageReceivedDelegate messageReceivedDelegate;

			private TokenReceivedDelegate tokenReceivedDelegate;

			private FirebaseApp app;

			private static Listener listener;

			internal static Listener Create()
			{
				return null;
			}

			internal static void Destroy()
			{
			}

			private Listener()
			{
			}

			~Listener()
			{
			}

			public void Dispose()
			{
			}

			private static int MessageReceivedDelegateMethod(IntPtr message)
			{
				return 0;
			}

			private static void TokenReceivedDelegateMethod(string token)
			{
			}
		}

		private static Listener listener;

		internal static event EventHandler<MessageReceivedEventArgs> MessageReceivedInternal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal static event EventHandler<TokenReceivedEventArgs> TokenReceivedInternal
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event EventHandler<MessageReceivedEventArgs> MessageReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event EventHandler<TokenReceivedEventArgs> TokenReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		internal static void CreateOrDestroyListener()
		{
		}

		static FirebaseMessaging()
		{
		}

		private static void SetListenerCallbacks(Listener.MessageReceivedDelegate messageCallback, Listener.TokenReceivedDelegate tokenCallback)
		{
		}

		private static void SetListenerCallbacksEnabled(bool message_callback_enabled, bool token_callback_enabled)
		{
		}

		private static void SendPendingEvents()
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;

namespace Firebase.Messaging
{
	public sealed class MessageReceivedEventArgs : EventArgs
	{
		public FirebaseMessage Message
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public MessageReceivedEventArgs(FirebaseMessage msg)
		{
		}
	}
}

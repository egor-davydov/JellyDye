using System;

namespace Cysharp.Threading.Tasks
{
	public class ChannelClosedException : InvalidOperationException
	{
		public ChannelClosedException()
		{
		}

		public ChannelClosedException(string message)
		{
		}

		public ChannelClosedException(Exception innerException)
		{
		}

		public ChannelClosedException(string message, Exception innerException)
		{
		}
	}
}

using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks
{
	public static class Channel
	{
		public static Channel<T> CreateSingleConsumerUnbounded<T>()
		{
			return null;
		}
	}
	public abstract class Channel<TWrite, TRead>
	{
		public ChannelReader<TRead> Reader
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public ChannelWriter<TWrite> Writer
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		public static implicit operator ChannelReader<TRead>(Channel<TWrite, TRead> channel)
		{
			return null;
		}

		public static implicit operator ChannelWriter<TWrite>(Channel<TWrite, TRead> channel)
		{
			return null;
		}
	}
	public abstract class Channel<T> : Channel<T, T>
	{
		protected Channel()
		{
			((Channel<, >)(object)this)._002Ector();
		}
	}
}

using System;

namespace Grpc.Core
{
	public sealed class ChannelOption : IEquatable<ChannelOption>
	{
		public enum OptionType
		{
			Integer = 0,
			String = 1
		}

		private readonly OptionType type;

		private readonly string name;

		private readonly int intValue;

		private readonly string stringValue;

		public OptionType Type => default(OptionType);

		public string Name => null;

		public int IntValue => 0;

		public string StringValue => null;

		public ChannelOption(string name, string stringValue)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ChannelOption other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(ChannelOption option1, ChannelOption option2)
		{
			return false;
		}

		public static bool operator !=(ChannelOption option1, ChannelOption option2)
		{
			return false;
		}
	}
}

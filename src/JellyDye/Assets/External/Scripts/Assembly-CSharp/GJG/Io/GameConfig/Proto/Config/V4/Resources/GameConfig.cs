using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Config.V4.Resources
{
	public sealed class GameConfig : IMessage<GameConfig>, IMessage, IEquatable<GameConfig>, IDeepCloneable<GameConfig>, IBufferMessage
	{
		private static readonly MessageParser<GameConfig> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ValuesFieldNumber = 1;

		private static readonly MapField<string, string>.Codec _map_values_codec;

		private readonly MapField<string, string> values_;

		[DebuggerNonUserCode]
		public static MessageParser<GameConfig> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public MapField<string, string> Values => null;

		[DebuggerNonUserCode]
		public GameConfig()
		{
		}

		[DebuggerNonUserCode]
		public GameConfig(GameConfig other)
		{
		}

		[DebuggerNonUserCode]
		public GameConfig Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GameConfig other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(GameConfig other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		[DebuggerNonUserCode]
		private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
		{
		}
	}
}

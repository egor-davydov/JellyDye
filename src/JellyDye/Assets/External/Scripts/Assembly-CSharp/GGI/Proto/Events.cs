using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace GGI.Proto
{
	public sealed class Events : IMessage<Events>, IMessage, IEquatable<Events>, IDeepCloneable<Events>
	{
		private static readonly MessageParser<Events> _parser;

		private UnknownFieldSet _unknownFields;

		public const int Events_FieldNumber = 1;

		private static readonly FieldCodec<Event> _repeated_events_codec;

		private readonly RepeatedField<Event> events_;

		[DebuggerNonUserCode]
		public static MessageParser<Events> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<Event> Events_ => null;

		[DebuggerNonUserCode]
		public Events()
		{
		}

		[DebuggerNonUserCode]
		public Events(Events other)
		{
		}

		[DebuggerNonUserCode]
		public Events Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Events other)
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
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Events other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}

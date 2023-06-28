using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class EventConfigSet : IMessage<EventConfigSet>, IMessage, IEquatable<EventConfigSet>, IDeepCloneable<EventConfigSet>, IBufferMessage
	{
		private static readonly MessageParser<EventConfigSet> _parser;

		private UnknownFieldSet _unknownFields;

		public const int EventsFieldNumber = 1;

		private static readonly FieldCodec<EventConfig> _repeated_events_codec;

		private readonly RepeatedField<EventConfig> events_;

		public const int OperatorFieldNumber = 2;

		private ChainOperator operator_;

		[DebuggerNonUserCode]
		public static MessageParser<EventConfigSet> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<EventConfig> Events => null;

		[DebuggerNonUserCode]
		public ChainOperator Operator
		{
			get
			{
				return default(ChainOperator);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public EventConfigSet()
		{
		}

		[DebuggerNonUserCode]
		public EventConfigSet(EventConfigSet other)
		{
		}

		[DebuggerNonUserCode]
		public EventConfigSet Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(EventConfigSet other)
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
		public void MergeFrom(EventConfigSet other)
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

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Client.Event
{
	public sealed class DispatchEventRequest : IMessage<DispatchEventRequest>, IMessage, IEquatable<DispatchEventRequest>, IDeepCloneable<DispatchEventRequest>, IBufferMessage
	{
		private static readonly MessageParser<DispatchEventRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int EventsFieldNumber = 1;

		private static readonly FieldCodec<ClientEvent> _repeated_events_codec;

		private readonly RepeatedField<ClientEvent> events_;

		[DebuggerNonUserCode]
		public static MessageParser<DispatchEventRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<ClientEvent> Events => null;

		[DebuggerNonUserCode]
		public DispatchEventRequest()
		{
		}

		[DebuggerNonUserCode]
		public DispatchEventRequest(DispatchEventRequest other)
		{
		}

		[DebuggerNonUserCode]
		public DispatchEventRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(DispatchEventRequest other)
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
		public void MergeFrom(DispatchEventRequest other)
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

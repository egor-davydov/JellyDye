using System;
using System.Diagnostics;
using Gjg.Io.Scio.Core.Event;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Client.Event
{
	public sealed class ClientEvent : IMessage<ClientEvent>, IMessage, IEquatable<ClientEvent>, IDeepCloneable<ClientEvent>, IBufferMessage
	{
		private static readonly MessageParser<ClientEvent> _parser;

		private UnknownFieldSet _unknownFields;

		public const int EventConfigIdFieldNumber = 1;

		private string eventConfigId_;

		public const int ValueFieldNumber = 2;

		private ParameterValue value_;

		[DebuggerNonUserCode]
		public static MessageParser<ClientEvent> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string EventConfigId
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public ParameterValue Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public ClientEvent()
		{
		}

		[DebuggerNonUserCode]
		public ClientEvent(ClientEvent other)
		{
		}

		[DebuggerNonUserCode]
		public ClientEvent Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ClientEvent other)
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
		public void MergeFrom(ClientEvent other)
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

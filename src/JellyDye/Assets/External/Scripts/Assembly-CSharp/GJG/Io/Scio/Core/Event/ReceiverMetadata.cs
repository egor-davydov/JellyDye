using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class ReceiverMetadata : IMessage<ReceiverMetadata>, IMessage, IEquatable<ReceiverMetadata>, IDeepCloneable<ReceiverMetadata>, IBufferMessage
	{
		private static readonly MessageParser<ReceiverMetadata> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AppIdFieldNumber = 1;

		private string appId_;

		public const int EventIdFieldNumber = 2;

		private string eventId_;

		public const int AppSecretFieldNumber = 3;

		private string appSecret_;

		[DebuggerNonUserCode]
		public static MessageParser<ReceiverMetadata> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string AppId
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
		public string EventId
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
		public string AppSecret
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
		public ReceiverMetadata()
		{
		}

		[DebuggerNonUserCode]
		public ReceiverMetadata(ReceiverMetadata other)
		{
		}

		[DebuggerNonUserCode]
		public ReceiverMetadata Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ReceiverMetadata other)
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
		public void MergeFrom(ReceiverMetadata other)
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

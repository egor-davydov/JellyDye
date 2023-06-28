using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class ReceiverNetwork : IMessage<ReceiverNetwork>, IMessage, IEquatable<ReceiverNetwork>, IDeepCloneable<ReceiverNetwork>, IBufferMessage
	{
		private static readonly MessageParser<ReceiverNetwork> _parser;

		private UnknownFieldSet _unknownFields;

		public const int NetworkTypeFieldNumber = 1;

		private ReceiverNetworkType networkType_;

		public const int PrefixFieldNumber = 2;

		private string prefix_;

		public const int IntervalFieldNumber = 3;

		private ReceiverInterval interval_;

		public const int MetadataFieldNumber = 4;

		private ReceiverMetadata metadata_;

		[DebuggerNonUserCode]
		public static MessageParser<ReceiverNetwork> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public ReceiverNetworkType NetworkType
		{
			get
			{
				return default(ReceiverNetworkType);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string Prefix
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
		public ReceiverInterval Interval
		{
			get
			{
				return default(ReceiverInterval);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public ReceiverMetadata Metadata
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
		public ReceiverNetwork()
		{
		}

		[DebuggerNonUserCode]
		public ReceiverNetwork(ReceiverNetwork other)
		{
		}

		[DebuggerNonUserCode]
		public ReceiverNetwork Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ReceiverNetwork other)
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
		public void MergeFrom(ReceiverNetwork other)
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

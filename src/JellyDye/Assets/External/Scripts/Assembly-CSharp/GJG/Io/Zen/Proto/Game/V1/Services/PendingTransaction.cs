using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Zen.Proto.Game.V1.Services
{
	public sealed class PendingTransaction : IMessage<PendingTransaction>, IMessage, IEquatable<PendingTransaction>, IDeepCloneable<PendingTransaction>, IBufferMessage
	{
		private static readonly MessageParser<PendingTransaction> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ItemsFieldNumber = 1;

		private static readonly MapField<string, string>.Codec _map_items_codec;

		private readonly MapField<string, string> items_;

		public const int SubmitTimestampFieldNumber = 2;

		private long submitTimestamp_;

		[DebuggerNonUserCode]
		public static MessageParser<PendingTransaction> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public MapField<string, string> Items => null;

		[DebuggerNonUserCode]
		public long SubmitTimestamp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public PendingTransaction()
		{
		}

		[DebuggerNonUserCode]
		public PendingTransaction(PendingTransaction other)
		{
		}

		[DebuggerNonUserCode]
		public PendingTransaction Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(PendingTransaction other)
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
		public void MergeFrom(PendingTransaction other)
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

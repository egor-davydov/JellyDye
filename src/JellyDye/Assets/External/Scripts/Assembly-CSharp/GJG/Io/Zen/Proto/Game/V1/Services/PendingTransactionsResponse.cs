using System;
using System.Diagnostics;
using Gjg.Io.Zen.Proto.Game.V1.Enums;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Zen.Proto.Game.V1.Services
{
	public sealed class PendingTransactionsResponse : IMessage<PendingTransactionsResponse>, IMessage, IEquatable<PendingTransactionsResponse>, IDeepCloneable<PendingTransactionsResponse>, IBufferMessage
	{
		private static readonly MessageParser<PendingTransactionsResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int TransactionsFieldNumber = 1;

		private static readonly FieldCodec<PendingTransaction> _repeated_transactions_codec;

		private readonly RepeatedField<PendingTransaction> transactions_;

		public const int StatusFieldNumber = 2;

		private Status status_;

		[DebuggerNonUserCode]
		public static MessageParser<PendingTransactionsResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<PendingTransaction> Transactions => null;

		[DebuggerNonUserCode]
		public Status Status
		{
			get
			{
				return default(Status);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public PendingTransactionsResponse()
		{
		}

		[DebuggerNonUserCode]
		public PendingTransactionsResponse(PendingTransactionsResponse other)
		{
		}

		[DebuggerNonUserCode]
		public PendingTransactionsResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(PendingTransactionsResponse other)
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
		public void MergeFrom(PendingTransactionsResponse other)
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

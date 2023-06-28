using System;
using System.Diagnostics;
using Gjg.Io.Zen.Proto.Game.V1.Enums;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Zen.Proto.Game.V1.Services
{
	public sealed class SubmitTransactionsResponse : IMessage<SubmitTransactionsResponse>, IMessage, IEquatable<SubmitTransactionsResponse>, IDeepCloneable<SubmitTransactionsResponse>, IBufferMessage
	{
		private static readonly MessageParser<SubmitTransactionsResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int StatusFieldNumber = 1;

		private Status status_;

		[DebuggerNonUserCode]
		public static MessageParser<SubmitTransactionsResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

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
		public SubmitTransactionsResponse()
		{
		}

		[DebuggerNonUserCode]
		public SubmitTransactionsResponse(SubmitTransactionsResponse other)
		{
		}

		[DebuggerNonUserCode]
		public SubmitTransactionsResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SubmitTransactionsResponse other)
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
		public void MergeFrom(SubmitTransactionsResponse other)
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

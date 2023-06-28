using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Zen.Proto.Game.V1.Services
{
	public sealed class SubmitTransactionRequest : IMessage<SubmitTransactionRequest>, IMessage, IEquatable<SubmitTransactionRequest>, IDeepCloneable<SubmitTransactionRequest>, IBufferMessage
	{
		private static readonly MessageParser<SubmitTransactionRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int UserIdFieldNumber = 1;

		private string userId_;

		public const int ItemsFieldNumber = 2;

		private static readonly MapField<string, string>.Codec _map_items_codec;

		private readonly MapField<string, string> items_;

		[DebuggerNonUserCode]
		public static MessageParser<SubmitTransactionRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string UserId
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
		public MapField<string, string> Items => null;

		[DebuggerNonUserCode]
		public SubmitTransactionRequest()
		{
		}

		[DebuggerNonUserCode]
		public SubmitTransactionRequest(SubmitTransactionRequest other)
		{
		}

		[DebuggerNonUserCode]
		public SubmitTransactionRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SubmitTransactionRequest other)
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
		public void MergeFrom(SubmitTransactionRequest other)
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

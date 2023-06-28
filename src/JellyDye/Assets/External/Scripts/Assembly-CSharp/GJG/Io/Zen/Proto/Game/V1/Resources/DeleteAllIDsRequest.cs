using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Zen.Proto.Game.V1.Resources
{
	public sealed class DeleteAllIDsRequest : IMessage<DeleteAllIDsRequest>, IMessage, IEquatable<DeleteAllIDsRequest>, IDeepCloneable<DeleteAllIDsRequest>, IBufferMessage
	{
		private static readonly MessageParser<DeleteAllIDsRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int UserIdFieldNumber = 1;

		private string userId_;

		public const int AppleIdFieldNumber = 3;

		private string appleId_;

		public const int FacebookIdFieldNumber = 4;

		private string facebookId_;

		[DebuggerNonUserCode]
		public static MessageParser<DeleteAllIDsRequest> Parser => null;

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
		public string AppleId
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
		public string FacebookId
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
		public DeleteAllIDsRequest()
		{
		}

		[DebuggerNonUserCode]
		public DeleteAllIDsRequest(DeleteAllIDsRequest other)
		{
		}

		[DebuggerNonUserCode]
		public DeleteAllIDsRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(DeleteAllIDsRequest other)
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
		public void MergeFrom(DeleteAllIDsRequest other)
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

using System;
using System.Diagnostics;
using Gjg.Io.Zen.Proto.Game.V1.Enums;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Zen.Proto.Game.V1.Resources
{
	public sealed class GetDocumentResponse : IMessage<GetDocumentResponse>, IMessage, IEquatable<GetDocumentResponse>, IDeepCloneable<GetDocumentResponse>, IBufferMessage
	{
		private static readonly MessageParser<GetDocumentResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int UserIdFieldNumber = 1;

		private string userId_;

		public const int DataFieldNumber = 2;

		private Document data_;

		public const int StatusFieldNumber = 3;

		private Status status_;

		public const int FacebookUserIdFieldNumber = 4;

		private string facebookUserId_;

		public const int AppleUserIdFieldNumber = 5;

		private string appleUserId_;

		[DebuggerNonUserCode]
		public static MessageParser<GetDocumentResponse> Parser => null;

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
		public Document Data
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
		public string FacebookUserId
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
		public string AppleUserId
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
		public GetDocumentResponse()
		{
		}

		[DebuggerNonUserCode]
		public GetDocumentResponse(GetDocumentResponse other)
		{
		}

		[DebuggerNonUserCode]
		public GetDocumentResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetDocumentResponse other)
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
		public void MergeFrom(GetDocumentResponse other)
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

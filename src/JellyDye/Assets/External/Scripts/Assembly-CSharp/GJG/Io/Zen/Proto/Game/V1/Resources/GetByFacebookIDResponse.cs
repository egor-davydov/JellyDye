using System;
using System.Diagnostics;
using Gjg.Io.Zen.Proto.Game.V1.Enums;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Zen.Proto.Game.V1.Resources
{
	public sealed class GetByFacebookIDResponse : IMessage<GetByFacebookIDResponse>, IMessage, IEquatable<GetByFacebookIDResponse>, IDeepCloneable<GetByFacebookIDResponse>, IBufferMessage
	{
		private static readonly MessageParser<GetByFacebookIDResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int FacebookUserIdFieldNumber = 1;

		private string facebookUserId_;

		public const int UserIdFieldNumber = 2;

		private string userId_;

		public const int DataFieldNumber = 3;

		private Document data_;

		public const int AppleUserIdFieldNumber = 4;

		private string appleUserId_;

		public const int StatusFieldNumber = 5;

		private Status status_;

		[DebuggerNonUserCode]
		public static MessageParser<GetByFacebookIDResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

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
		public GetByFacebookIDResponse()
		{
		}

		[DebuggerNonUserCode]
		public GetByFacebookIDResponse(GetByFacebookIDResponse other)
		{
		}

		[DebuggerNonUserCode]
		public GetByFacebookIDResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetByFacebookIDResponse other)
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
		public void MergeFrom(GetByFacebookIDResponse other)
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

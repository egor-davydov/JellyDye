using System;
using System.Diagnostics;
using Gjg.Io.Zen.Proto.Game.V1.Enums;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Zen.Proto.Game.V1.Resources
{
	public sealed class GetAllIDsResponse : IMessage<GetAllIDsResponse>, IMessage, IEquatable<GetAllIDsResponse>, IDeepCloneable<GetAllIDsResponse>, IBufferMessage
	{
		private static readonly MessageParser<GetAllIDsResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int UserIdFieldNumber = 1;

		private string userId_;

		public const int DataFieldNumber = 2;

		private Document data_;

		public const int DataTypeFieldNumber = 3;

		private DataSourceType dataType_;

		public const int StatusFieldNumber = 4;

		private Status status_;

		[DebuggerNonUserCode]
		public static MessageParser<GetAllIDsResponse> Parser => null;

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
		public DataSourceType DataType
		{
			get
			{
				return default(DataSourceType);
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
		public GetAllIDsResponse()
		{
		}

		[DebuggerNonUserCode]
		public GetAllIDsResponse(GetAllIDsResponse other)
		{
		}

		[DebuggerNonUserCode]
		public GetAllIDsResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetAllIDsResponse other)
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
		public void MergeFrom(GetAllIDsResponse other)
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

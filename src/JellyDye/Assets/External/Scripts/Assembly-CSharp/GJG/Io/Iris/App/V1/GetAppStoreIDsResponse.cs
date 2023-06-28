using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.App.V1
{
	public sealed class GetAppStoreIDsResponse : IMessage<GetAppStoreIDsResponse>, IMessage, IEquatable<GetAppStoreIDsResponse>, IDeepCloneable<GetAppStoreIDsResponse>, IBufferMessage
	{
		private static readonly MessageParser<GetAppStoreIDsResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdsFieldNumber = 1;

		private static readonly FieldCodec<AppStoreID> _repeated_ids_codec;

		private readonly RepeatedField<AppStoreID> ids_;

		[DebuggerNonUserCode]
		public static MessageParser<GetAppStoreIDsResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<AppStoreID> Ids => null;

		[DebuggerNonUserCode]
		public GetAppStoreIDsResponse()
		{
		}

		[DebuggerNonUserCode]
		public GetAppStoreIDsResponse(GetAppStoreIDsResponse other)
		{
		}

		[DebuggerNonUserCode]
		public GetAppStoreIDsResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetAppStoreIDsResponse other)
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
		public void MergeFrom(GetAppStoreIDsResponse other)
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

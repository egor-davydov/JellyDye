using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.App.V1
{
	public sealed class GetAppMonetizationNetworkIDsResponse : IMessage<GetAppMonetizationNetworkIDsResponse>, IMessage, IEquatable<GetAppMonetizationNetworkIDsResponse>, IDeepCloneable<GetAppMonetizationNetworkIDsResponse>, IBufferMessage
	{
		private static readonly MessageParser<GetAppMonetizationNetworkIDsResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdsFieldNumber = 1;

		private static readonly FieldCodec<AppNetworkID> _repeated_ids_codec;

		private readonly RepeatedField<AppNetworkID> ids_;

		[DebuggerNonUserCode]
		public static MessageParser<GetAppMonetizationNetworkIDsResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<AppNetworkID> Ids => null;

		[DebuggerNonUserCode]
		public GetAppMonetizationNetworkIDsResponse()
		{
		}

		[DebuggerNonUserCode]
		public GetAppMonetizationNetworkIDsResponse(GetAppMonetizationNetworkIDsResponse other)
		{
		}

		[DebuggerNonUserCode]
		public GetAppMonetizationNetworkIDsResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetAppMonetizationNetworkIDsResponse other)
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
		public void MergeFrom(GetAppMonetizationNetworkIDsResponse other)
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

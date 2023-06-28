using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.App.V1
{
	public sealed class GetAppAdUnitsResponse : IMessage<GetAppAdUnitsResponse>, IMessage, IEquatable<GetAppAdUnitsResponse>, IDeepCloneable<GetAppAdUnitsResponse>, IBufferMessage
	{
		private static readonly MessageParser<GetAppAdUnitsResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AdUnitsFieldNumber = 1;

		private static readonly FieldCodec<AppAdUnit> _repeated_adUnits_codec;

		private readonly RepeatedField<AppAdUnit> adUnits_;

		[DebuggerNonUserCode]
		public static MessageParser<GetAppAdUnitsResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<AppAdUnit> AdUnits => null;

		[DebuggerNonUserCode]
		public GetAppAdUnitsResponse()
		{
		}

		[DebuggerNonUserCode]
		public GetAppAdUnitsResponse(GetAppAdUnitsResponse other)
		{
		}

		[DebuggerNonUserCode]
		public GetAppAdUnitsResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetAppAdUnitsResponse other)
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
		public void MergeFrom(GetAppAdUnitsResponse other)
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

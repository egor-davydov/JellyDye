using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.App.V1
{
	public sealed class GetAppNamesResponse : IMessage<GetAppNamesResponse>, IMessage, IEquatable<GetAppNamesResponse>, IDeepCloneable<GetAppNamesResponse>, IBufferMessage
	{
		private static readonly MessageParser<GetAppNamesResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AppsFieldNumber = 1;

		private static readonly FieldCodec<AppName> _repeated_apps_codec;

		private readonly RepeatedField<AppName> apps_;

		[DebuggerNonUserCode]
		public static MessageParser<GetAppNamesResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<AppName> Apps => null;

		[DebuggerNonUserCode]
		public GetAppNamesResponse()
		{
		}

		[DebuggerNonUserCode]
		public GetAppNamesResponse(GetAppNamesResponse other)
		{
		}

		[DebuggerNonUserCode]
		public GetAppNamesResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetAppNamesResponse other)
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
		public void MergeFrom(GetAppNamesResponse other)
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

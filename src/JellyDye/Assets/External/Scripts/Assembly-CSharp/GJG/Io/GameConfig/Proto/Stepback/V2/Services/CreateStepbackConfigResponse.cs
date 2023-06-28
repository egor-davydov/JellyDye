using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Stepback.V2.Services
{
	public sealed class CreateStepbackConfigResponse : IMessage<CreateStepbackConfigResponse>, IMessage, IEquatable<CreateStepbackConfigResponse>, IDeepCloneable<CreateStepbackConfigResponse>, IBufferMessage
	{
		private static readonly MessageParser<CreateStepbackConfigResponse> _parser;

		private UnknownFieldSet _unknownFields;

		[DebuggerNonUserCode]
		public static MessageParser<CreateStepbackConfigResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public CreateStepbackConfigResponse()
		{
		}

		[DebuggerNonUserCode]
		public CreateStepbackConfigResponse(CreateStepbackConfigResponse other)
		{
		}

		[DebuggerNonUserCode]
		public CreateStepbackConfigResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CreateStepbackConfigResponse other)
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
		public void MergeFrom(CreateStepbackConfigResponse other)
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

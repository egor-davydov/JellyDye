using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Client.Event
{
	public sealed class UpdateSegmentResponse : IMessage<UpdateSegmentResponse>, IMessage, IEquatable<UpdateSegmentResponse>, IDeepCloneable<UpdateSegmentResponse>, IBufferMessage
	{
		private static readonly MessageParser<UpdateSegmentResponse> _parser;

		private UnknownFieldSet _unknownFields;

		[DebuggerNonUserCode]
		public static MessageParser<UpdateSegmentResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public UpdateSegmentResponse()
		{
		}

		[DebuggerNonUserCode]
		public UpdateSegmentResponse(UpdateSegmentResponse other)
		{
		}

		[DebuggerNonUserCode]
		public UpdateSegmentResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(UpdateSegmentResponse other)
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
		public void MergeFrom(UpdateSegmentResponse other)
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

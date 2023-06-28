using System;
using System.Diagnostics;
using Gjg.Io.Scio.Core.Event;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Client.Event
{
	public sealed class GetSegmentsRequest : IMessage<GetSegmentsRequest>, IMessage, IEquatable<GetSegmentsRequest>, IDeepCloneable<GetSegmentsRequest>, IBufferMessage
	{
		private static readonly MessageParser<GetSegmentsRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AppBundleIdFieldNumber = 1;

		private string appBundleId_;

		public const int PlatformFieldNumber = 2;

		private Platform platform_;

		[DebuggerNonUserCode]
		public static MessageParser<GetSegmentsRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string AppBundleId
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
		public Platform Platform
		{
			get
			{
				return default(Platform);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public GetSegmentsRequest()
		{
		}

		[DebuggerNonUserCode]
		public GetSegmentsRequest(GetSegmentsRequest other)
		{
		}

		[DebuggerNonUserCode]
		public GetSegmentsRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetSegmentsRequest other)
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
		public void MergeFrom(GetSegmentsRequest other)
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

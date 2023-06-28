using System;
using System.Diagnostics;
using Gjg.Io.Scio.Core.Event;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Client.Event
{
	public sealed class ScheduleRequest : IMessage<ScheduleRequest>, IMessage, IEquatable<ScheduleRequest>, IDeepCloneable<ScheduleRequest>, IBufferMessage
	{
		private static readonly MessageParser<ScheduleRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int SegmentFieldNumber = 1;

		private Segment segment_;

		public const int DateFieldNumber = 2;

		private string date_;

		[DebuggerNonUserCode]
		public static MessageParser<ScheduleRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public Segment Segment
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
		public string Date
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
		public ScheduleRequest()
		{
		}

		[DebuggerNonUserCode]
		public ScheduleRequest(ScheduleRequest other)
		{
		}

		[DebuggerNonUserCode]
		public ScheduleRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ScheduleRequest other)
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
		public void MergeFrom(ScheduleRequest other)
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

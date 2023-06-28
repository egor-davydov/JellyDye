using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class EventInfo : IMessage<EventInfo>, IMessage, IEquatable<EventInfo>, IDeepCloneable<EventInfo>, IBufferMessage
	{
		public enum InfoOneofCase
		{
			None = 0,
			LevelEventInfo = 1,
			RevenueEventInfo = 2
		}

		private static readonly MessageParser<EventInfo> _parser;

		private UnknownFieldSet _unknownFields;

		public const int LevelEventInfoFieldNumber = 1;

		public const int RevenueEventInfoFieldNumber = 2;

		private object info_;

		private InfoOneofCase infoCase_;

		[DebuggerNonUserCode]
		public static MessageParser<EventInfo> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public LevelEventInfo LevelEventInfo
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
		public RevenueEventInfo RevenueEventInfo
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
		public InfoOneofCase InfoCase => default(InfoOneofCase);

		[DebuggerNonUserCode]
		public EventInfo()
		{
		}

		[DebuggerNonUserCode]
		public EventInfo(EventInfo other)
		{
		}

		[DebuggerNonUserCode]
		public EventInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void ClearInfo()
		{
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(EventInfo other)
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
		public void MergeFrom(EventInfo other)
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

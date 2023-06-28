using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class RevenueEventInfo : IMessage<RevenueEventInfo>, IMessage, IEquatable<RevenueEventInfo>, IDeepCloneable<RevenueEventInfo>, IBufferMessage
	{
		private static readonly MessageParser<RevenueEventInfo> _parser;

		private UnknownFieldSet _unknownFields;

		public const int LevelProgressFieldNumber = 1;

		private int levelProgress_;

		public const int RevenueFieldNumber = 2;

		private string revenue_;

		public const int LevelStatusFieldNumber = 3;

		private bool levelStatus_;

		[DebuggerNonUserCode]
		public static MessageParser<RevenueEventInfo> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public int LevelProgress
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string Revenue
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
		public bool LevelStatus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public RevenueEventInfo()
		{
		}

		[DebuggerNonUserCode]
		public RevenueEventInfo(RevenueEventInfo other)
		{
		}

		[DebuggerNonUserCode]
		public RevenueEventInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RevenueEventInfo other)
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
		public void MergeFrom(RevenueEventInfo other)
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

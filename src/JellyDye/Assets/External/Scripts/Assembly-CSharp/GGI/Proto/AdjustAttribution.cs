using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace GGI.Proto
{
	public sealed class AdjustAttribution : IMessage<AdjustAttribution>, IMessage, IEquatable<AdjustAttribution>, IDeepCloneable<AdjustAttribution>
	{
		private static readonly MessageParser<AdjustAttribution> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AdIDFieldNumber = 1;

		private string adID_;

		public const int NetworkFieldNumber = 2;

		private string network_;

		public const int AdGroupFieldNumber = 3;

		private string adGroup_;

		public const int CampaignFieldNumber = 4;

		private string campaign_;

		public const int CreativeFieldNumber = 5;

		private string creative_;

		public const int ClickLabelFieldNumber = 6;

		private string clickLabel_;

		public const int TrackerNameFieldNumber = 7;

		private string trackerName_;

		public const int TrackerTokenFieldNumber = 8;

		private string trackerToken_;

		[DebuggerNonUserCode]
		public static MessageParser<AdjustAttribution> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string AdID
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
		public string Network
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
		public string AdGroup
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
		public string Campaign
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
		public string Creative
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
		public string ClickLabel
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
		public string TrackerName
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
		public string TrackerToken
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
		public AdjustAttribution()
		{
		}

		[DebuggerNonUserCode]
		public AdjustAttribution(AdjustAttribution other)
		{
		}

		[DebuggerNonUserCode]
		public AdjustAttribution Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AdjustAttribution other)
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
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(AdjustAttribution other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}

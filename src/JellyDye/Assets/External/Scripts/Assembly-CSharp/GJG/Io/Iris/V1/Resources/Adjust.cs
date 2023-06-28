using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class Adjust : IMessage<Adjust>, IMessage, IEquatable<Adjust>, IDeepCloneable<Adjust>, IBufferMessage
	{
		private static readonly MessageParser<Adjust> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AppTokenFieldNumber = 1;

		private string appToken_;

		public const int BannerImpressionEventFieldNumber = 2;

		private string bannerImpressionEvent_;

		public const int InterstitialImpressionEventFieldNumber = 3;

		private string interstitialImpressionEvent_;

		public const int InterstitialClickEventFieldNumber = 4;

		private string interstitialClickEvent_;

		public const int RewardedImpressionEventFieldNumber = 5;

		private string rewardedImpressionEvent_;

		[DebuggerNonUserCode]
		public static MessageParser<Adjust> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string AppToken
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
		public string BannerImpressionEvent
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
		public string InterstitialImpressionEvent
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
		public string InterstitialClickEvent
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
		public string RewardedImpressionEvent
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
		public Adjust()
		{
		}

		[DebuggerNonUserCode]
		public Adjust(Adjust other)
		{
		}

		[DebuggerNonUserCode]
		public Adjust Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Adjust other)
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
		public void MergeFrom(Adjust other)
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

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class MoPubAdUnit : IMessage<MoPubAdUnit>, IMessage, IEquatable<MoPubAdUnit>, IDeepCloneable<MoPubAdUnit>, IBufferMessage
	{
		private static readonly MessageParser<MoPubAdUnit> _parser;

		private UnknownFieldSet _unknownFields;

		public const int BannerAdUnitIdFieldNumber = 1;

		private string bannerAdUnitId_;

		public const int InterstitialUnitIdFieldNumber = 2;

		private string interstitialUnitId_;

		public const int RewardedUnitIdFieldNumber = 3;

		private string rewardedUnitId_;

		[DebuggerNonUserCode]
		public static MessageParser<MoPubAdUnit> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string BannerAdUnitId
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
		public string InterstitialUnitId
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
		public string RewardedUnitId
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
		public MoPubAdUnit()
		{
		}

		[DebuggerNonUserCode]
		public MoPubAdUnit(MoPubAdUnit other)
		{
		}

		[DebuggerNonUserCode]
		public MoPubAdUnit Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MoPubAdUnit other)
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
		public void MergeFrom(MoPubAdUnit other)
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

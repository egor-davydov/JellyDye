using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Stepback.V1.Resources
{
	public sealed class Config : IMessage<Config>, IMessage, IEquatable<Config>, IDeepCloneable<Config>, IBufferMessage
	{
		private static readonly MessageParser<Config> _parser;

		private UnknownFieldSet _unknownFields;

		public const int BannerCpmThresholdsFieldNumber = 1;

		private static readonly FieldCodec<CPMThreshold> _repeated_bannerCpmThresholds_codec;

		private readonly RepeatedField<CPMThreshold> bannerCpmThresholds_;

		public const int InterstitialCpmThresholdsFieldNumber = 2;

		private static readonly FieldCodec<CPMThreshold> _repeated_interstitialCpmThresholds_codec;

		private readonly RepeatedField<CPMThreshold> interstitialCpmThresholds_;

		public const int RewardedCpmThresholdsFieldNumber = 3;

		private static readonly FieldCodec<CPMThreshold> _repeated_rewardedCpmThresholds_codec;

		private readonly RepeatedField<CPMThreshold> rewardedCpmThresholds_;

		public const int SampledFieldNumber = 4;

		private bool sampled_;

		[DebuggerNonUserCode]
		public static MessageParser<Config> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<CPMThreshold> BannerCpmThresholds => null;

		[DebuggerNonUserCode]
		public RepeatedField<CPMThreshold> InterstitialCpmThresholds => null;

		[DebuggerNonUserCode]
		public RepeatedField<CPMThreshold> RewardedCpmThresholds => null;

		[DebuggerNonUserCode]
		public bool Sampled
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
		public Config()
		{
		}

		[DebuggerNonUserCode]
		public Config(Config other)
		{
		}

		[DebuggerNonUserCode]
		public Config Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Config other)
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
		public void MergeFrom(Config other)
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

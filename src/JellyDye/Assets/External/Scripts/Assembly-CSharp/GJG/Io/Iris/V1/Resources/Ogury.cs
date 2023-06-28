using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class Ogury : IMessage<Ogury>, IMessage, IEquatable<Ogury>, IDeepCloneable<Ogury>, IBufferMessage
	{
		private static readonly MessageParser<Ogury> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AppKeyFieldNumber = 1;

		private string appKey_;

		public const int AppIdFieldNumber = 2;

		private string appId_;

		public const int BannerAdUnitIdFieldNumber = 3;

		private string bannerAdUnitId_;

		public const int InterstitialAdUnitIdFieldNumber = 4;

		private string interstitialAdUnitId_;

		public const int RewardedAdUnitIdFieldNumber = 5;

		private string rewardedAdUnitId_;

		[DebuggerNonUserCode]
		public static MessageParser<Ogury> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string AppKey
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
		public string AppId
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
		public string InterstitialAdUnitId
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
		public string RewardedAdUnitId
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
		public Ogury()
		{
		}

		[DebuggerNonUserCode]
		public Ogury(Ogury other)
		{
		}

		[DebuggerNonUserCode]
		public Ogury Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Ogury other)
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
		public void MergeFrom(Ogury other)
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

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.PostInit.V2.Services
{
	public sealed class GetConversionValueRequest : IMessage<GetConversionValueRequest>, IMessage, IEquatable<GetConversionValueRequest>, IDeepCloneable<GetConversionValueRequest>, IBufferMessage
	{
		private static readonly MessageParser<GetConversionValueRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AdvertisingIdFieldNumber = 1;

		private string advertisingId_;

		public const int AppBundleIdFieldNumber = 2;

		private string appBundleId_;

		public const int OsFieldNumber = 3;

		private string os_;

		public const int BuildNumberFieldNumber = 4;

		private string buildNumber_;

		public const int AppBundleVersionFieldNumber = 5;

		private string appBundleVersion_;

		public const int SdkVersionFieldNumber = 6;

		private string sdkVersion_;

		public const int DeviceIdFieldNumber = 7;

		private string deviceId_;

		public const int GameIdFieldNumber = 8;

		private string gameId_;

		public const int UserIdFieldNumber = 9;

		private string userId_;

		public const int LanguageFieldNumber = 10;

		private string language_;

		public const int IsTabletFieldNumber = 11;

		private bool isTablet_;

		public const int IspFieldNumber = 12;

		private string isp_;

		public const int LocaleFieldNumber = 13;

		private string locale_;

		public const int DeviceModelFieldNumber = 14;

		private string deviceModel_;

		public const int DeviceOsVersionFieldNumber = 15;

		private string deviceOsVersion_;

		public const int TimezoneOffsetFieldNumber = 16;

		private string timezoneOffset_;

		public const int FreeDiskpaceFieldNumber = 17;

		private string freeDiskpace_;

		public const int TotalDiskspaceFieldNumber = 18;

		private string totalDiskspace_;

		public const int AttStatusFieldNumber = 19;

		private long attStatus_;

		public const int FirstEventTimestampFieldNumber = 20;

		private long firstEventTimestamp_;

		public const int SessionNumberFieldNumber = 21;

		private long sessionNumber_;

		public const int SumRevenueFieldNumber = 22;

		private float sumRevenue_;

		public const int SumBannerRevenueFieldNumber = 23;

		private float sumBannerRevenue_;

		public const int SumInterstitialRevenueFieldNumber = 24;

		private float sumInterstitialRevenue_;

		public const int SumRewardedRevenueFieldNumber = 25;

		private float sumRewardedRevenue_;

		public const int SumBannerImpressionsFieldNumber = 26;

		private long sumBannerImpressions_;

		public const int SumInterstitialImpressionsFieldNumber = 27;

		private long sumInterstitialImpressions_;

		public const int SumRewardedImpressionsFieldNumber = 28;

		private long sumRewardedImpressions_;

		public const int LevelEventsFieldNumber = 29;

		private long levelEvents_;

		public const int SuccessfulLevelEventsFieldNumber = 30;

		private long successfulLevelEvents_;

		public const int SumIapRevenueFieldNumber = 31;

		private float sumIapRevenue_;

		public const int IapCurrencyFieldNumber = 32;

		private string iapCurrency_;

		[DebuggerNonUserCode]
		public static MessageParser<GetConversionValueRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string AdvertisingId
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
		public string Os
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
		public string BuildNumber
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
		public string AppBundleVersion
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
		public string SdkVersion
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
		public string DeviceId
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
		public string GameId
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
		public string UserId
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
		public string Language
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
		public bool IsTablet
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
		public string Isp
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
		public string Locale
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
		public string DeviceModel
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
		public string DeviceOsVersion
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
		public string TimezoneOffset
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
		public string FreeDiskpace
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
		public string TotalDiskspace
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
		public long AttStatus
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long FirstEventTimestamp
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long SessionNumber
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public float SumRevenue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public float SumBannerRevenue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public float SumInterstitialRevenue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public float SumRewardedRevenue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long SumBannerImpressions
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long SumInterstitialImpressions
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long SumRewardedImpressions
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long LevelEvents
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long SuccessfulLevelEvents
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public float SumIapRevenue
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string IapCurrency
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
		public GetConversionValueRequest()
		{
		}

		[DebuggerNonUserCode]
		public GetConversionValueRequest(GetConversionValueRequest other)
		{
		}

		[DebuggerNonUserCode]
		public GetConversionValueRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetConversionValueRequest other)
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
		public void MergeFrom(GetConversionValueRequest other)
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

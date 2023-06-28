using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.Config.V4.Services
{
	public sealed class GetConfigRequest : IMessage<GetConfigRequest>, IMessage, IEquatable<GetConfigRequest>, IDeepCloneable<GetConfigRequest>, IBufferMessage
	{
		private static readonly MessageParser<GetConfigRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AppBundleIdFieldNumber = 1;

		private string appBundleId_;

		public const int OsFieldNumber = 2;

		private string os_;

		public const int BuildNumberFieldNumber = 3;

		private string buildNumber_;

		public const int AppBundleVersionFieldNumber = 4;

		private string appBundleVersion_;

		public const int SdkVersionFieldNumber = 5;

		private string sdkVersion_;

		public const int DeviceIdFieldNumber = 6;

		private string deviceId_;

		public const int GameIdFieldNumber = 7;

		private string gameId_;

		public const int UserIdFieldNumber = 8;

		private string userId_;

		public const int StepbackConfigIdFieldNumber = 9;

		private long stepbackConfigId_;

		public const int EligibleForStepbackSamplingFieldNumber = 10;

		private bool eligibleForStepbackSampling_;

		public const int LanguageFieldNumber = 11;

		private string language_;

		public const int IsTabletFieldNumber = 12;

		private bool isTablet_;

		public const int IspFieldNumber = 13;

		private string isp_;

		public const int LocaleFieldNumber = 14;

		private string locale_;

		public const int DeviceModelFieldNumber = 15;

		private string deviceModel_;

		public const int DeviceOsVersionFieldNumber = 16;

		private string deviceOsVersion_;

		public const int TimezoneOffsetFieldNumber = 17;

		private string timezoneOffset_;

		public const int FreeDiskpaceFieldNumber = 18;

		private string freeDiskpace_;

		public const int TotalDiskspaceFieldNumber = 19;

		private string totalDiskspace_;

		public const int AttStatusFieldNumber = 20;

		private long attStatus_;

		public const int AdvertisingIdFieldNumber = 21;

		private string advertisingId_;

		[DebuggerNonUserCode]
		public static MessageParser<GetConfigRequest> Parser => null;

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
		public long StepbackConfigId
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
		public bool EligibleForStepbackSampling
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
		public GetConfigRequest()
		{
		}

		[DebuggerNonUserCode]
		public GetConfigRequest(GetConfigRequest other)
		{
		}

		[DebuggerNonUserCode]
		public GetConfigRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetConfigRequest other)
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
		public void MergeFrom(GetConfigRequest other)
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

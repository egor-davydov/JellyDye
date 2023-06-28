using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class Platform : IMessage<Platform>, IMessage, IEquatable<Platform>, IDeepCloneable<Platform>, IBufferMessage
	{
		private static readonly MessageParser<Platform> _parser;

		private UnknownFieldSet _unknownFields;

		public const int DisplayNameFieldNumber = 1;

		private string displayName_;

		public const int PlusIdFieldNumber = 2;

		private long plusId_;

		public const int BundleIdFieldNumber = 3;

		private string bundleId_;

		public const int StoreIdFieldNumber = 4;

		private string storeId_;

		public const int GoogleSheetsIdFieldNumber = 5;

		private string googleSheetsId_;

		public const int AdjustFieldNumber = 6;

		private static readonly MapField<string, Adjust>.Codec _map_adjust_codec;

		private readonly MapField<string, Adjust> adjust_;

		public const int FacebookFieldNumber = 7;

		private static readonly MapField<string, Facebook>.Codec _map_facebook_codec;

		private readonly MapField<string, Facebook> facebook_;

		public const int MopubFieldNumber = 8;

		private static readonly MapField<string, MoPub>.Codec _map_mopub_codec;

		private readonly MapField<string, MoPub> mopub_;

		public const int BigqueryFieldNumber = 9;

		private static readonly MapField<string, Bigquery>.Codec _map_bigquery_codec;

		private readonly MapField<string, Bigquery> bigquery_;

		public const int AdmobFieldNumber = 10;

		private static readonly MapField<string, AdMob>.Codec _map_admob_codec;

		private readonly MapField<string, AdMob> admob_;

		public const int FyberFieldNumber = 11;

		private static readonly MapField<string, Fyber>.Codec _map_fyber_codec;

		private readonly MapField<string, Fyber> fyber_;

		public const int IronSourceFieldNumber = 12;

		private static readonly MapField<string, IronSource>.Codec _map_ironSource_codec;

		private readonly MapField<string, IronSource> ironSource_;

		public const int OguryFieldNumber = 13;

		private static readonly MapField<string, Ogury>.Codec _map_ogury_codec;

		private readonly MapField<string, Ogury> ogury_;

		public const int TiktokFieldNumber = 14;

		private static readonly MapField<string, TikTok>.Codec _map_tiktok_codec;

		private readonly MapField<string, TikTok> tiktok_;

		public const int UnityFieldNumber = 15;

		private static readonly MapField<string, Unity>.Codec _map_unity_codec;

		private readonly MapField<string, Unity> unity_;

		public const int VungleFieldNumber = 16;

		private static readonly MapField<string, Vungle>.Codec _map_vungle_codec;

		private readonly MapField<string, Vungle> vungle_;

		public const int ApplovinFieldNumber = 17;

		private static readonly MapField<string, Applovin>.Codec _map_applovin_codec;

		private readonly MapField<string, Applovin> applovin_;

		public const int SearchadsFieldNumber = 18;

		private static readonly MapField<string, SearchAds>.Codec _map_searchads_codec;

		private readonly MapField<string, SearchAds> searchads_;

		public const int TaichiFieldNumber = 19;

		private static readonly MapField<string, Taichi>.Codec _map_taichi_codec;

		private readonly MapField<string, Taichi> taichi_;

		public const int LtvFieldNumber = 20;

		private static readonly MapField<string, LTV>.Codec _map_ltv_codec;

		private readonly MapField<string, LTV> ltv_;

		public const int TapjoyFieldNumber = 21;

		private static readonly MapField<string, Tapjoy>.Codec _map_tapjoy_codec;

		private readonly MapField<string, Tapjoy> tapjoy_;

		public const int MintegralFieldNumber = 22;

		private static readonly MapField<string, Mintegral>.Codec _map_mintegral_codec;

		private readonly MapField<string, Mintegral> mintegral_;

		public const int VerizonFieldNumber = 23;

		private static readonly MapField<string, Verizon>.Codec _map_verizon_codec;

		private readonly MapField<string, Verizon> verizon_;

		[DebuggerNonUserCode]
		public static MessageParser<Platform> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string DisplayName
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
		public long PlusId
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
		public string BundleId
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
		public string StoreId
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
		public string GoogleSheetsId
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
		public MapField<string, Adjust> Adjust => null;

		[DebuggerNonUserCode]
		public MapField<string, Facebook> Facebook => null;

		[DebuggerNonUserCode]
		public MapField<string, MoPub> Mopub => null;

		[DebuggerNonUserCode]
		public MapField<string, Bigquery> Bigquery => null;

		[DebuggerNonUserCode]
		public MapField<string, AdMob> Admob => null;

		[DebuggerNonUserCode]
		public MapField<string, Fyber> Fyber => null;

		[DebuggerNonUserCode]
		public MapField<string, IronSource> IronSource => null;

		[DebuggerNonUserCode]
		public MapField<string, Ogury> Ogury => null;

		[DebuggerNonUserCode]
		public MapField<string, TikTok> Tiktok => null;

		[DebuggerNonUserCode]
		public MapField<string, Unity> Unity => null;

		[DebuggerNonUserCode]
		public MapField<string, Vungle> Vungle => null;

		[DebuggerNonUserCode]
		public MapField<string, Applovin> Applovin => null;

		[DebuggerNonUserCode]
		public MapField<string, SearchAds> Searchads => null;

		[DebuggerNonUserCode]
		public MapField<string, Taichi> Taichi => null;

		[DebuggerNonUserCode]
		public MapField<string, LTV> Ltv => null;

		[DebuggerNonUserCode]
		public MapField<string, Tapjoy> Tapjoy => null;

		[DebuggerNonUserCode]
		public MapField<string, Mintegral> Mintegral => null;

		[DebuggerNonUserCode]
		public MapField<string, Verizon> Verizon => null;

		[DebuggerNonUserCode]
		public Platform()
		{
		}

		[DebuggerNonUserCode]
		public Platform(Platform other)
		{
		}

		[DebuggerNonUserCode]
		public Platform Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Platform other)
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
		public void MergeFrom(Platform other)
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

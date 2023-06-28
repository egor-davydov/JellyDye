using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.GDPR.V1.Services
{
	public sealed class GiveConsentRequest : IMessage<GiveConsentRequest>, IMessage, IEquatable<GiveConsentRequest>, IDeepCloneable<GiveConsentRequest>, IBufferMessage
	{
		private static readonly MessageParser<GiveConsentRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AdvertisingIdFieldNumber = 1;

		private string advertisingId_;

		public const int AdsConsentFieldNumber = 2;

		private bool adsConsent_;

		public const int AppBundleIdFieldNumber = 3;

		private string appBundleId_;

		[DebuggerNonUserCode]
		public static MessageParser<GiveConsentRequest> Parser => null;

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
		public bool AdsConsent
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
		public GiveConsentRequest()
		{
		}

		[DebuggerNonUserCode]
		public GiveConsentRequest(GiveConsentRequest other)
		{
		}

		[DebuggerNonUserCode]
		public GiveConsentRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GiveConsentRequest other)
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
		public void MergeFrom(GiveConsentRequest other)
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

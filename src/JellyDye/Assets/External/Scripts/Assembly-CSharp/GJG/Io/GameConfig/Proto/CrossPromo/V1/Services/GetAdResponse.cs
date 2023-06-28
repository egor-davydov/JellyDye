using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.GameConfig.Proto.CrossPromo.V1.Services
{
	public sealed class GetAdResponse : IMessage<GetAdResponse>, IMessage, IEquatable<GetAdResponse>, IDeepCloneable<GetAdResponse>, IBufferMessage
	{
		private static readonly MessageParser<GetAdResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int SignatureFieldNumber = 1;

		private string signature_;

		public const int CampaignIdFieldNumber = 2;

		private string campaignId_;

		public const int SkAdNetworkIdFieldNumber = 3;

		private string skAdNetworkId_;

		public const int NonceFieldNumber = 4;

		private string nonce_;

		public const int TimestampFieldNumber = 5;

		private string timestamp_;

		public const int SourceAppIdFieldNumber = 6;

		private string sourceAppId_;

		public const int TargetAppIdFieldNumber = 7;

		private string targetAppId_;

		public const int SkAdNetworkVersionFieldNumber = 8;

		private string skAdNetworkVersion_;

		[DebuggerNonUserCode]
		public static MessageParser<GetAdResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string Signature
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
		public string CampaignId
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
		public string SkAdNetworkId
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
		public string Nonce
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
		public string Timestamp
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
		public string SourceAppId
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
		public string TargetAppId
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
		public string SkAdNetworkVersion
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
		public GetAdResponse()
		{
		}

		[DebuggerNonUserCode]
		public GetAdResponse(GetAdResponse other)
		{
		}

		[DebuggerNonUserCode]
		public GetAdResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetAdResponse other)
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
		public void MergeFrom(GetAdResponse other)
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

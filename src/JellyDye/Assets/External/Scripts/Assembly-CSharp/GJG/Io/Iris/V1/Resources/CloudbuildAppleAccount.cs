using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class CloudbuildAppleAccount : IMessage<CloudbuildAppleAccount>, IMessage, IEquatable<CloudbuildAppleAccount>, IDeepCloneable<CloudbuildAppleAccount>, IBufferMessage
	{
		private static readonly MessageParser<CloudbuildAppleAccount> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdFieldNumber = 1;

		private string id_;

		public const int DisplayNameFieldNumber = 2;

		private string displayName_;

		public const int IsBusinessFieldNumber = 3;

		private bool isBusiness_;

		public const int ProviderIdFieldNumber = 4;

		private string providerId_;

		public const int ProviderNameFieldNumber = 5;

		private string providerName_;

		public const int TeamIdFieldNumber = 6;

		private string teamId_;

		[DebuggerNonUserCode]
		public static MessageParser<CloudbuildAppleAccount> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string Id
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
		public bool IsBusiness
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
		public string ProviderId
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
		public string ProviderName
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
		public string TeamId
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
		public CloudbuildAppleAccount()
		{
		}

		[DebuggerNonUserCode]
		public CloudbuildAppleAccount(CloudbuildAppleAccount other)
		{
		}

		[DebuggerNonUserCode]
		public CloudbuildAppleAccount Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CloudbuildAppleAccount other)
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
		public void MergeFrom(CloudbuildAppleAccount other)
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

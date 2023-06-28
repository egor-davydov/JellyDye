using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class Cloudbuild : IMessage<Cloudbuild>, IMessage, IEquatable<Cloudbuild>, IDeepCloneable<Cloudbuild>, IBufferMessage
	{
		private static readonly MessageParser<Cloudbuild> _parser;

		private UnknownFieldSet _unknownFields;

		public const int EnabledFieldNumber = 1;

		private bool enabled_;

		public const int EnabledChinaFieldNumber = 2;

		private bool enabledChina_;

		public const int AccountIdFieldNumber = 3;

		private string accountId_;

		public const int ProvisionProfileNameFieldNumber = 4;

		private string provisionProfileName_;

		[DebuggerNonUserCode]
		public static MessageParser<Cloudbuild> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public bool Enabled
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
		public bool EnabledChina
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
		public string AccountId
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
		public string ProvisionProfileName
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
		public Cloudbuild()
		{
		}

		[DebuggerNonUserCode]
		public Cloudbuild(Cloudbuild other)
		{
		}

		[DebuggerNonUserCode]
		public Cloudbuild Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Cloudbuild other)
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
		public void MergeFrom(Cloudbuild other)
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

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class CloudbuildAppleAccounts : IMessage<CloudbuildAppleAccounts>, IMessage, IEquatable<CloudbuildAppleAccounts>, IDeepCloneable<CloudbuildAppleAccounts>, IBufferMessage
	{
		private static readonly MessageParser<CloudbuildAppleAccounts> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AccountsFieldNumber = 1;

		private static readonly FieldCodec<CloudbuildAppleAccount> _repeated_accounts_codec;

		private readonly RepeatedField<CloudbuildAppleAccount> accounts_;

		[DebuggerNonUserCode]
		public static MessageParser<CloudbuildAppleAccounts> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public RepeatedField<CloudbuildAppleAccount> Accounts => null;

		[DebuggerNonUserCode]
		public CloudbuildAppleAccounts()
		{
		}

		[DebuggerNonUserCode]
		public CloudbuildAppleAccounts(CloudbuildAppleAccounts other)
		{
		}

		[DebuggerNonUserCode]
		public CloudbuildAppleAccounts Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CloudbuildAppleAccounts other)
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
		public void MergeFrom(CloudbuildAppleAccounts other)
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

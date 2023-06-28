using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Zen.Proto.Game.V1.Resources
{
	public sealed class SetFacebookIDRequest : IMessage<SetFacebookIDRequest>, IMessage, IEquatable<SetFacebookIDRequest>, IDeepCloneable<SetFacebookIDRequest>, IBufferMessage
	{
		private static readonly MessageParser<SetFacebookIDRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int UserIdFieldNumber = 1;

		private string userId_;

		public const int FacebookUserIdFieldNumber = 2;

		private string facebookUserId_;

		public const int BundleIdFieldNumber = 3;

		private string bundleId_;

		[DebuggerNonUserCode]
		public static MessageParser<SetFacebookIDRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

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
		public string FacebookUserId
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
		public SetFacebookIDRequest()
		{
		}

		[DebuggerNonUserCode]
		public SetFacebookIDRequest(SetFacebookIDRequest other)
		{
		}

		[DebuggerNonUserCode]
		public SetFacebookIDRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SetFacebookIDRequest other)
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
		public void MergeFrom(SetFacebookIDRequest other)
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

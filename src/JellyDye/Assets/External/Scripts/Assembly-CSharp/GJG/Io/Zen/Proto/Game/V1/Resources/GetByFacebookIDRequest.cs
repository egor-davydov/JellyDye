using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Zen.Proto.Game.V1.Resources
{
	public sealed class GetByFacebookIDRequest : IMessage<GetByFacebookIDRequest>, IMessage, IEquatable<GetByFacebookIDRequest>, IDeepCloneable<GetByFacebookIDRequest>, IBufferMessage
	{
		private static readonly MessageParser<GetByFacebookIDRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int FacebookUserIdFieldNumber = 1;

		private string facebookUserId_;

		public const int BundleIdFieldNumber = 2;

		private string bundleId_;

		[DebuggerNonUserCode]
		public static MessageParser<GetByFacebookIDRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

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
		public GetByFacebookIDRequest()
		{
		}

		[DebuggerNonUserCode]
		public GetByFacebookIDRequest(GetByFacebookIDRequest other)
		{
		}

		[DebuggerNonUserCode]
		public GetByFacebookIDRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GetByFacebookIDRequest other)
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
		public void MergeFrom(GetByFacebookIDRequest other)
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

using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.App.V1
{
	public sealed class PutAppStoreIDRequest : IMessage<PutAppStoreIDRequest>, IMessage, IEquatable<PutAppStoreIDRequest>, IDeepCloneable<PutAppStoreIDRequest>, IBufferMessage
	{
		private static readonly MessageParser<PutAppStoreIDRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdFieldNumber = 1;

		private string id_;

		public const int StoreIdFieldNumber = 2;

		private AppStoreID storeId_;

		[DebuggerNonUserCode]
		public static MessageParser<PutAppStoreIDRequest> Parser => null;

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
		public AppStoreID StoreId
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
		public PutAppStoreIDRequest()
		{
		}

		[DebuggerNonUserCode]
		public PutAppStoreIDRequest(PutAppStoreIDRequest other)
		{
		}

		[DebuggerNonUserCode]
		public PutAppStoreIDRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(PutAppStoreIDRequest other)
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
		public void MergeFrom(PutAppStoreIDRequest other)
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

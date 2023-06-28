using System;
using System.Diagnostics;
using Gjg.Io.Iris.V1.Resources;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Services
{
	public sealed class MutateAppRequest : IMessage<MutateAppRequest>, IMessage, IEquatable<MutateAppRequest>, IDeepCloneable<MutateAppRequest>, IBufferMessage
	{
		private static readonly MessageParser<MutateAppRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AppFieldNumber = 1;

		private Gjg.Io.Iris.V1.Resources.App app_;

		[DebuggerNonUserCode]
		public static MessageParser<MutateAppRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public Gjg.Io.Iris.V1.Resources.App App
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
		public MutateAppRequest()
		{
		}

		[DebuggerNonUserCode]
		public MutateAppRequest(MutateAppRequest other)
		{
		}

		[DebuggerNonUserCode]
		public MutateAppRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MutateAppRequest other)
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
		public void MergeFrom(MutateAppRequest other)
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

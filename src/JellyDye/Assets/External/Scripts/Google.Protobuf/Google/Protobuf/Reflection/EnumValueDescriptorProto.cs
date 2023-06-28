using System;
using System.Diagnostics;

namespace Google.Protobuf.Reflection
{
	public sealed class EnumValueDescriptorProto : IMessage<EnumValueDescriptorProto>, IMessage, IEquatable<EnumValueDescriptorProto>, IDeepCloneable<EnumValueDescriptorProto>, IBufferMessage
	{
		private static readonly MessageParser<EnumValueDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private int _hasBits0;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly int NumberDefaultValue;

		private int number_;

		private EnumValueOptions options_;

		[DebuggerNonUserCode]
		public static MessageParser<EnumValueDescriptorProto> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string Name
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
		public bool HasName => false;

		[DebuggerNonUserCode]
		public int Number
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasNumber => false;

		[DebuggerNonUserCode]
		public EnumValueOptions Options
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
		public EnumValueDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public EnumValueDescriptorProto(EnumValueDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public EnumValueDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumValueDescriptorProto other)
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
		public void MergeFrom(EnumValueDescriptorProto other)
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

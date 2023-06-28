using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IMessage, IEquatable<EnumDescriptorProto>, IDeepCloneable<EnumDescriptorProto>, IBufferMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class EnumReservedRange : IMessage<EnumReservedRange>, IMessage, IEquatable<EnumReservedRange>, IDeepCloneable<EnumReservedRange>, IBufferMessage
			{
				private static readonly MessageParser<EnumReservedRange> _parser;

				private UnknownFieldSet _unknownFields;

				private int _hasBits0;

				private static readonly int StartDefaultValue;

				private int start_;

				private static readonly int EndDefaultValue;

				private int end_;

				[DebuggerNonUserCode]
				public static MessageParser<EnumReservedRange> Parser => null;

				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor => null;

				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

				[DebuggerNonUserCode]
				public int Start
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
				public bool HasStart => false;

				[DebuggerNonUserCode]
				public int End
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
				public bool HasEnd => false;

				[DebuggerNonUserCode]
				public EnumReservedRange()
				{
				}

				[DebuggerNonUserCode]
				public EnumReservedRange(EnumReservedRange other)
				{
				}

				[DebuggerNonUserCode]
				public EnumReservedRange Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(EnumReservedRange other)
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
				public void MergeFrom(EnumReservedRange other)
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

		private static readonly MessageParser<EnumDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec;

		private readonly RepeatedField<EnumValueDescriptorProto> value_;

		private EnumOptions options_;

		private static readonly FieldCodec<Types.EnumReservedRange> _repeated_reservedRange_codec;

		private readonly RepeatedField<Types.EnumReservedRange> reservedRange_;

		private static readonly FieldCodec<string> _repeated_reservedName_codec;

		private readonly RepeatedField<string> reservedName_;

		[DebuggerNonUserCode]
		public static MessageParser<EnumDescriptorProto> Parser => null;

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
		public RepeatedField<EnumValueDescriptorProto> Value => null;

		[DebuggerNonUserCode]
		public EnumOptions Options
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
		public EnumDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public EnumDescriptorProto(EnumDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public EnumDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumDescriptorProto other)
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
		public void MergeFrom(EnumDescriptorProto other)
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

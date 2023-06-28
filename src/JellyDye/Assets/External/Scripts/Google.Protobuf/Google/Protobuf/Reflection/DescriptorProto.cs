using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class DescriptorProto : IMessage<DescriptorProto>, IMessage, IEquatable<DescriptorProto>, IDeepCloneable<DescriptorProto>, IBufferMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class ExtensionRange : IMessage<ExtensionRange>, IMessage, IEquatable<ExtensionRange>, IDeepCloneable<ExtensionRange>, IBufferMessage
			{
				private static readonly MessageParser<ExtensionRange> _parser;

				private UnknownFieldSet _unknownFields;

				private int _hasBits0;

				private static readonly int StartDefaultValue;

				private int start_;

				private static readonly int EndDefaultValue;

				private int end_;

				private ExtensionRangeOptions options_;

				[DebuggerNonUserCode]
				public static MessageParser<ExtensionRange> Parser => null;

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
				public ExtensionRangeOptions Options
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
				public ExtensionRange()
				{
				}

				[DebuggerNonUserCode]
				public ExtensionRange(ExtensionRange other)
				{
				}

				[DebuggerNonUserCode]
				public ExtensionRange Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(ExtensionRange other)
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
				public void MergeFrom(ExtensionRange other)
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

			public sealed class ReservedRange : IMessage<ReservedRange>, IMessage, IEquatable<ReservedRange>, IDeepCloneable<ReservedRange>, IBufferMessage
			{
				private static readonly MessageParser<ReservedRange> _parser;

				private UnknownFieldSet _unknownFields;

				private int _hasBits0;

				private static readonly int StartDefaultValue;

				private int start_;

				private static readonly int EndDefaultValue;

				private int end_;

				[DebuggerNonUserCode]
				public static MessageParser<ReservedRange> Parser => null;

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
				public ReservedRange()
				{
				}

				[DebuggerNonUserCode]
				public ReservedRange(ReservedRange other)
				{
				}

				[DebuggerNonUserCode]
				public ReservedRange Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(ReservedRange other)
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
				public void MergeFrom(ReservedRange other)
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

		private static readonly MessageParser<DescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec;

		private readonly RepeatedField<FieldDescriptorProto> field_;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec;

		private readonly RepeatedField<FieldDescriptorProto> extension_;

		private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec;

		private readonly RepeatedField<DescriptorProto> nestedType_;

		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec;

		private readonly RepeatedField<EnumDescriptorProto> enumType_;

		private static readonly FieldCodec<Types.ExtensionRange> _repeated_extensionRange_codec;

		private readonly RepeatedField<Types.ExtensionRange> extensionRange_;

		private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec;

		private readonly RepeatedField<OneofDescriptorProto> oneofDecl_;

		private MessageOptions options_;

		private static readonly FieldCodec<Types.ReservedRange> _repeated_reservedRange_codec;

		private readonly RepeatedField<Types.ReservedRange> reservedRange_;

		private static readonly FieldCodec<string> _repeated_reservedName_codec;

		private readonly RepeatedField<string> reservedName_;

		[DebuggerNonUserCode]
		public static MessageParser<DescriptorProto> Parser => null;

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
		public RepeatedField<FieldDescriptorProto> Field => null;

		[DebuggerNonUserCode]
		public RepeatedField<FieldDescriptorProto> Extension => null;

		[DebuggerNonUserCode]
		public RepeatedField<DescriptorProto> NestedType => null;

		[DebuggerNonUserCode]
		public RepeatedField<EnumDescriptorProto> EnumType => null;

		[DebuggerNonUserCode]
		public RepeatedField<OneofDescriptorProto> OneofDecl => null;

		[DebuggerNonUserCode]
		public MessageOptions Options
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
		public DescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public DescriptorProto(DescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public DescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(DescriptorProto other)
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
		public void MergeFrom(DescriptorProto other)
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

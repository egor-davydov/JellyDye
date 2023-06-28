using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class UninterpretedOption : IMessage<UninterpretedOption>, IMessage, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>, IBufferMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class NamePart : IMessage<NamePart>, IMessage, IEquatable<NamePart>, IDeepCloneable<NamePart>, IBufferMessage
			{
				private static readonly MessageParser<NamePart> _parser;

				private UnknownFieldSet _unknownFields;

				private int _hasBits0;

				private static readonly string NamePart_DefaultValue;

				private string namePart_;

				private static readonly bool IsExtensionDefaultValue;

				private bool isExtension_;

				[DebuggerNonUserCode]
				public static MessageParser<NamePart> Parser => null;

				[DebuggerNonUserCode]
				public static MessageDescriptor Descriptor => null;

				[DebuggerNonUserCode]
				private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

				[DebuggerNonUserCode]
				public string NamePart_
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
				public bool HasNamePart_ => false;

				[DebuggerNonUserCode]
				public bool IsExtension
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
				public bool HasIsExtension => false;

				[DebuggerNonUserCode]
				public NamePart()
				{
				}

				[DebuggerNonUserCode]
				public NamePart(NamePart other)
				{
				}

				[DebuggerNonUserCode]
				public NamePart Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(NamePart other)
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
				public void MergeFrom(NamePart other)
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

		private static readonly MessageParser<UninterpretedOption> _parser;

		private UnknownFieldSet _unknownFields;

		private int _hasBits0;

		private static readonly FieldCodec<Types.NamePart> _repeated_name_codec;

		private readonly RepeatedField<Types.NamePart> name_;

		private static readonly string IdentifierValueDefaultValue;

		private string identifierValue_;

		private static readonly ulong PositiveIntValueDefaultValue;

		private ulong positiveIntValue_;

		private static readonly long NegativeIntValueDefaultValue;

		private long negativeIntValue_;

		private static readonly double DoubleValueDefaultValue;

		private double doubleValue_;

		private static readonly ByteString StringValueDefaultValue;

		private ByteString stringValue_;

		private static readonly string AggregateValueDefaultValue;

		private string aggregateValue_;

		[DebuggerNonUserCode]
		public static MessageParser<UninterpretedOption> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string IdentifierValue
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
		public bool HasIdentifierValue => false;

		[DebuggerNonUserCode]
		public ulong PositiveIntValue
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasPositiveIntValue => false;

		[DebuggerNonUserCode]
		public long NegativeIntValue
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasNegativeIntValue => false;

		[DebuggerNonUserCode]
		public double DoubleValue
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasDoubleValue => false;

		[DebuggerNonUserCode]
		public ByteString StringValue
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
		public bool HasStringValue => false;

		[DebuggerNonUserCode]
		public string AggregateValue
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
		public bool HasAggregateValue => false;

		[DebuggerNonUserCode]
		public UninterpretedOption()
		{
		}

		[DebuggerNonUserCode]
		public UninterpretedOption(UninterpretedOption other)
		{
		}

		[DebuggerNonUserCode]
		public UninterpretedOption Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(UninterpretedOption other)
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
		public void MergeFrom(UninterpretedOption other)
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

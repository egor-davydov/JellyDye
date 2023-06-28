using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class MessageOptions : IExtendableMessage<MessageOptions>, IMessage<MessageOptions>, IMessage, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>, IBufferMessage
	{
		private static readonly MessageParser<MessageOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<MessageOptions> _extensions;

		private int _hasBits0;

		private static readonly bool MessageSetWireFormatDefaultValue;

		private bool messageSetWireFormat_;

		private static readonly bool NoStandardDescriptorAccessorDefaultValue;

		private bool noStandardDescriptorAccessor_;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly bool MapEntryDefaultValue;

		private bool mapEntry_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<MessageOptions> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public bool MessageSetWireFormat
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
		public bool HasMessageSetWireFormat => false;

		[DebuggerNonUserCode]
		public bool NoStandardDescriptorAccessor
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
		public bool HasNoStandardDescriptorAccessor => false;

		[DebuggerNonUserCode]
		public bool Deprecated
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
		public bool HasDeprecated => false;

		[DebuggerNonUserCode]
		public bool MapEntry
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
		public bool HasMapEntry => false;

		[DebuggerNonUserCode]
		public MessageOptions()
		{
		}

		[DebuggerNonUserCode]
		public MessageOptions(MessageOptions other)
		{
		}

		[DebuggerNonUserCode]
		public MessageOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MessageOptions other)
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
		public void MergeFrom(MessageOptions other)
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

		public TValue GetExtension<TValue>(Extension<MessageOptions, TValue> extension)
		{
			return default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension)
		{
			return null;
		}

		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<MessageOptions, TValue> extension)
		{
			return false;
		}

		public void ClearExtension<TValue>(Extension<MessageOptions, TValue> extension)
		{
		}
	}
}

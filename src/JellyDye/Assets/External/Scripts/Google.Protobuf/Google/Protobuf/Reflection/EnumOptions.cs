using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class EnumOptions : IExtendableMessage<EnumOptions>, IMessage<EnumOptions>, IMessage, IEquatable<EnumOptions>, IDeepCloneable<EnumOptions>, IBufferMessage
	{
		private static readonly MessageParser<EnumOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<EnumOptions> _extensions;

		private int _hasBits0;

		private static readonly bool AllowAliasDefaultValue;

		private bool allowAlias_;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<EnumOptions> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public bool AllowAlias
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
		public bool HasAllowAlias => false;

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
		public EnumOptions()
		{
		}

		[DebuggerNonUserCode]
		public EnumOptions(EnumOptions other)
		{
		}

		[DebuggerNonUserCode]
		public EnumOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(EnumOptions other)
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
		public void MergeFrom(EnumOptions other)
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

		public TValue GetExtension<TValue>(Extension<EnumOptions, TValue> extension)
		{
			return default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension)
		{
			return null;
		}

		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<EnumOptions, TValue> extension)
		{
			return false;
		}

		public void ClearExtension<TValue>(Extension<EnumOptions, TValue> extension)
		{
		}
	}
}

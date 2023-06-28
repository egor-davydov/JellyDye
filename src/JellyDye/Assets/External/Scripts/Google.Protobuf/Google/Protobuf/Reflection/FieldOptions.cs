using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class FieldOptions : IExtendableMessage<FieldOptions>, IMessage<FieldOptions>, IMessage, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>, IBufferMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum CType
			{
				String = 0,
				Cord = 1,
				StringPiece = 2
			}

			public enum JSType
			{
				JsNormal = 0,
				JsString = 1,
				JsNumber = 2
			}
		}

		private static readonly MessageParser<FieldOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<FieldOptions> _extensions;

		private int _hasBits0;

		private static readonly Types.CType CtypeDefaultValue;

		private Types.CType ctype_;

		private static readonly bool PackedDefaultValue;

		private bool packed_;

		private static readonly Types.JSType JstypeDefaultValue;

		private Types.JSType jstype_;

		private static readonly bool LazyDefaultValue;

		private bool lazy_;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly bool WeakDefaultValue;

		private bool weak_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<FieldOptions> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public Types.CType Ctype
		{
			get
			{
				return default(Types.CType);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasCtype => false;

		[DebuggerNonUserCode]
		public bool Packed
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
		public bool HasPacked => false;

		[DebuggerNonUserCode]
		public Types.JSType Jstype
		{
			get
			{
				return default(Types.JSType);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasJstype => false;

		[DebuggerNonUserCode]
		public bool Lazy
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
		public bool HasLazy => false;

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
		public bool Weak
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
		public bool HasWeak => false;

		[DebuggerNonUserCode]
		public FieldOptions()
		{
		}

		[DebuggerNonUserCode]
		public FieldOptions(FieldOptions other)
		{
		}

		[DebuggerNonUserCode]
		public FieldOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldOptions other)
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
		public void MergeFrom(FieldOptions other)
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

		public TValue GetExtension<TValue>(Extension<FieldOptions, TValue> extension)
		{
			return default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension)
		{
			return null;
		}

		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<FieldOptions, TValue> extension)
		{
			return false;
		}

		public void ClearExtension<TValue>(Extension<FieldOptions, TValue> extension)
		{
		}
	}
}

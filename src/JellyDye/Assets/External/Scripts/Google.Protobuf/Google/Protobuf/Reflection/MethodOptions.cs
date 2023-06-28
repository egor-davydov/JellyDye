using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class MethodOptions : IExtendableMessage<MethodOptions>, IMessage<MethodOptions>, IMessage, IEquatable<MethodOptions>, IDeepCloneable<MethodOptions>, IBufferMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum IdempotencyLevel
			{
				IdempotencyUnknown = 0,
				NoSideEffects = 1,
				Idempotent = 2
			}
		}

		private static readonly MessageParser<MethodOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<MethodOptions> _extensions;

		private int _hasBits0;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly Types.IdempotencyLevel IdempotencyLevelDefaultValue;

		private Types.IdempotencyLevel idempotencyLevel_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<MethodOptions> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

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
		public Types.IdempotencyLevel IdempotencyLevel
		{
			get
			{
				return default(Types.IdempotencyLevel);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasIdempotencyLevel => false;

		[DebuggerNonUserCode]
		public MethodOptions()
		{
		}

		[DebuggerNonUserCode]
		public MethodOptions(MethodOptions other)
		{
		}

		[DebuggerNonUserCode]
		public MethodOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MethodOptions other)
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
		public void MergeFrom(MethodOptions other)
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

		public TValue GetExtension<TValue>(Extension<MethodOptions, TValue> extension)
		{
			return default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension)
		{
			return null;
		}

		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<MethodOptions, TValue> extension)
		{
			return false;
		}

		public void ClearExtension<TValue>(Extension<MethodOptions, TValue> extension)
		{
		}
	}
}

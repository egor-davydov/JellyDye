using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Type : IMessage<Type>, IMessage, IEquatable<Type>, IDeepCloneable<Type>, IBufferMessage
	{
		private static readonly MessageParser<Type> _parser;

		private UnknownFieldSet _unknownFields;

		private string name_;

		private static readonly FieldCodec<Field> _repeated_fields_codec;

		private readonly RepeatedField<Field> fields_;

		private static readonly FieldCodec<string> _repeated_oneofs_codec;

		private readonly RepeatedField<string> oneofs_;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_;

		private SourceContext sourceContext_;

		private Syntax syntax_;

		[DebuggerNonUserCode]
		public static MessageParser<Type> Parser => null;

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
		public SourceContext SourceContext
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
		public Syntax Syntax
		{
			get
			{
				return default(Syntax);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Type()
		{
		}

		[DebuggerNonUserCode]
		public Type(Type other)
		{
		}

		[DebuggerNonUserCode]
		public Type Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Type other)
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
		public void MergeFrom(Type other)
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

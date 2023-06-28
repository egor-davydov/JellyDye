using System;
using System.Diagnostics;

namespace Google.Protobuf.Reflection
{
	public sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IMessage, IEquatable<FieldDescriptorProto>, IDeepCloneable<FieldDescriptorProto>, IBufferMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum Type
			{
				Double = 1,
				Float = 2,
				Int64 = 3,
				Uint64 = 4,
				Int32 = 5,
				Fixed64 = 6,
				Fixed32 = 7,
				Bool = 8,
				String = 9,
				Group = 10,
				Message = 11,
				Bytes = 12,
				Uint32 = 13,
				Enum = 14,
				Sfixed32 = 15,
				Sfixed64 = 16,
				Sint32 = 17,
				Sint64 = 18
			}

			public enum Label
			{
				Optional = 1,
				Required = 2,
				Repeated = 3
			}
		}

		private static readonly MessageParser<FieldDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private int _hasBits0;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly int NumberDefaultValue;

		private int number_;

		private static readonly Types.Label LabelDefaultValue;

		private Types.Label label_;

		private static readonly Types.Type TypeDefaultValue;

		private Types.Type type_;

		private static readonly string TypeNameDefaultValue;

		private string typeName_;

		private static readonly string ExtendeeDefaultValue;

		private string extendee_;

		private static readonly string DefaultValueDefaultValue;

		private string defaultValue_;

		private static readonly int OneofIndexDefaultValue;

		private int oneofIndex_;

		private static readonly string JsonNameDefaultValue;

		private string jsonName_;

		private FieldOptions options_;

		private static readonly bool Proto3OptionalDefaultValue;

		private bool proto3Optional_;

		[DebuggerNonUserCode]
		public static MessageParser<FieldDescriptorProto> Parser => null;

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
		public Types.Label Label
		{
			get
			{
				return default(Types.Label);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasLabel => false;

		[DebuggerNonUserCode]
		public Types.Type Type
		{
			get
			{
				return default(Types.Type);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasType => false;

		[DebuggerNonUserCode]
		public string TypeName
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
		public bool HasTypeName => false;

		[DebuggerNonUserCode]
		public string Extendee
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
		public bool HasExtendee => false;

		[DebuggerNonUserCode]
		public string DefaultValue
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
		public bool HasDefaultValue => false;

		[DebuggerNonUserCode]
		public int OneofIndex
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
		public bool HasOneofIndex => false;

		[DebuggerNonUserCode]
		public string JsonName
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
		public bool HasJsonName => false;

		[DebuggerNonUserCode]
		public FieldOptions Options
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
		public bool Proto3Optional
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
		public bool HasProto3Optional => false;

		[DebuggerNonUserCode]
		public FieldDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto(FieldDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public FieldDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldDescriptorProto other)
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
		public void MergeFrom(FieldDescriptorProto other)
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

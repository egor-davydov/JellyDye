using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>, IBufferMessage
	{
		public enum KindOneofCase
		{
			None = 0,
			NullValue = 1,
			NumberValue = 2,
			StringValue = 3,
			BoolValue = 4,
			StructValue = 5,
			ListValue = 6
		}

		private static readonly MessageParser<Value> _parser;

		private UnknownFieldSet _unknownFields;

		private object kind_;

		private KindOneofCase kindCase_;

		[DebuggerNonUserCode]
		public static MessageParser<Value> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public NullValue NullValue
		{
			get
			{
				return default(NullValue);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public double NumberValue
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
		public string StringValue
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
		public bool BoolValue
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
		public Struct StructValue
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
		public ListValue ListValue
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
		public KindOneofCase KindCase => default(KindOneofCase);

		[DebuggerNonUserCode]
		public Value()
		{
		}

		[DebuggerNonUserCode]
		public Value(Value other)
		{
		}

		[DebuggerNonUserCode]
		public Value Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Value other)
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
		public void MergeFrom(Value other)
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

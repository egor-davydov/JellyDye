using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class ParameterValue : IMessage<ParameterValue>, IMessage, IEquatable<ParameterValue>, IDeepCloneable<ParameterValue>, IBufferMessage
	{
		public enum ValueOneofCase
		{
			None = 0,
			StringValue = 1,
			DoubleValue = 2,
			IntValue = 3
		}

		private static readonly MessageParser<ParameterValue> _parser;

		private UnknownFieldSet _unknownFields;

		public const int StringValueFieldNumber = 1;

		public const int DoubleValueFieldNumber = 2;

		public const int IntValueFieldNumber = 3;

		private object value_;

		private ValueOneofCase valueCase_;

		[DebuggerNonUserCode]
		public static MessageParser<ParameterValue> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

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
		public string DoubleValue
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
		public long IntValue
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
		public ValueOneofCase ValueCase => default(ValueOneofCase);

		[DebuggerNonUserCode]
		public ParameterValue()
		{
		}

		[DebuggerNonUserCode]
		public ParameterValue(ParameterValue other)
		{
		}

		[DebuggerNonUserCode]
		public ParameterValue Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void ClearValue()
		{
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ParameterValue other)
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
		public void MergeFrom(ParameterValue other)
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

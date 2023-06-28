using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class Condition : IMessage<Condition>, IMessage, IEquatable<Condition>, IDeepCloneable<Condition>, IBufferMessage
	{
		private static readonly MessageParser<Condition> _parser;

		private UnknownFieldSet _unknownFields;

		public const int ValueFieldNumber = 1;

		private string value_;

		public const int OperatorFieldNumber = 2;

		private LevelConditionOperator operator_;

		[DebuggerNonUserCode]
		public static MessageParser<Condition> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string Value
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
		public LevelConditionOperator Operator
		{
			get
			{
				return default(LevelConditionOperator);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Condition()
		{
		}

		[DebuggerNonUserCode]
		public Condition(Condition other)
		{
		}

		[DebuggerNonUserCode]
		public Condition Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Condition other)
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
		public void MergeFrom(Condition other)
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

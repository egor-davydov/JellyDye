using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class EventConfig : IMessage<EventConfig>, IMessage, IEquatable<EventConfig>, IDeepCloneable<EventConfig>, IBufferMessage
	{
		private static readonly MessageParser<EventConfig> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdFieldNumber = 1;

		private string id_;

		public const int NameFieldNumber = 2;

		private string name_;

		public const int AggregatorFieldNumber = 3;

		private CalculationAggregator aggregator_;

		public const int TimeRestrictionFieldNumber = 4;

		private long timeRestriction_;

		public const int ParameterValueFieldNumber = 5;

		private TargetParameterValue parameterValue_;

		public const int OccurrenceFieldNumber = 6;

		private OccurrenceType occurrence_;

		public const int TypeFieldNumber = 7;

		private EventType type_;

		public const int YieldFieldNumber = 8;

		private bool yield_;

		public const int ConditionFieldNumber = 9;

		private Condition condition_;

		[DebuggerNonUserCode]
		public static MessageParser<EventConfig> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string Id
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
		public CalculationAggregator Aggregator
		{
			get
			{
				return default(CalculationAggregator);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long TimeRestriction
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
		public TargetParameterValue ParameterValue
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
		public OccurrenceType Occurrence
		{
			get
			{
				return default(OccurrenceType);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public EventType Type
		{
			get
			{
				return default(EventType);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool Yield
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
		public Condition Condition
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
		public EventConfig()
		{
		}

		[DebuggerNonUserCode]
		public EventConfig(EventConfig other)
		{
		}

		[DebuggerNonUserCode]
		public EventConfig Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(EventConfig other)
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
		public void MergeFrom(EventConfig other)
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

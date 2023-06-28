using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class InterceptorBoundedContext : IMessage<InterceptorBoundedContext>, IMessage, IEquatable<InterceptorBoundedContext>, IDeepCloneable<InterceptorBoundedContext>, IBufferMessage
	{
		private static readonly MessageParser<InterceptorBoundedContext> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdFieldNumber = 1;

		private string id_;

		public const int SegmentFieldNumber = 2;

		private Segment segment_;

		public const int ValueFieldNumber = 3;

		private ParameterValue value_;

		public const int CreatedAtFieldNumber = 5;

		private long createdAt_;

		public const int CustomerDataFieldNumber = 6;

		private CustomerData customerData_;

		public const int ReceiverNetworkFieldNumber = 7;

		private ReceiverNetwork receiverNetwork_;

		[DebuggerNonUserCode]
		public static MessageParser<InterceptorBoundedContext> Parser => null;

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
		public Segment Segment
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
		public ParameterValue Value
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
		public long CreatedAt
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
		public CustomerData CustomerData
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
		public ReceiverNetwork ReceiverNetwork
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
		public InterceptorBoundedContext()
		{
		}

		[DebuggerNonUserCode]
		public InterceptorBoundedContext(InterceptorBoundedContext other)
		{
		}

		[DebuggerNonUserCode]
		public InterceptorBoundedContext Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(InterceptorBoundedContext other)
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
		public void MergeFrom(InterceptorBoundedContext other)
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

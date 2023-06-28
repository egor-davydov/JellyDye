using System;
using System.Diagnostics;
using Gjg.Io.Scio.Core.Event;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Client.Event
{
	public sealed class TriggerRequest : IMessage<TriggerRequest>, IMessage, IEquatable<TriggerRequest>, IDeepCloneable<TriggerRequest>, IBufferMessage
	{
		private static readonly MessageParser<TriggerRequest> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AppBundleIdFieldNumber = 1;

		private string appBundleId_;

		public const int PlatformFieldNumber = 2;

		private Platform platform_;

		public const int SegmentIdFieldNumber = 3;

		private string segmentId_;

		public const int EventsFieldNumber = 4;

		private static readonly FieldCodec<ClientEvent> _repeated_events_codec;

		private readonly RepeatedField<ClientEvent> events_;

		public const int CustomerDataFieldNumber = 5;

		private CustomerData customerData_;

		public const int EventMetadataFieldNumber = 6;

		private EventMetadata eventMetadata_;

		[DebuggerNonUserCode]
		public static MessageParser<TriggerRequest> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string AppBundleId
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
		public Platform Platform
		{
			get
			{
				return default(Platform);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string SegmentId
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
		public RepeatedField<ClientEvent> Events => null;

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
		public EventMetadata EventMetadata
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
		public TriggerRequest()
		{
		}

		[DebuggerNonUserCode]
		public TriggerRequest(TriggerRequest other)
		{
		}

		[DebuggerNonUserCode]
		public TriggerRequest Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(TriggerRequest other)
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
		public void MergeFrom(TriggerRequest other)
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

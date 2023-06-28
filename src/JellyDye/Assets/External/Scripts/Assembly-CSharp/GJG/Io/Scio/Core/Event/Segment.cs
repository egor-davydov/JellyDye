using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class Segment : IMessage<Segment>, IMessage, IEquatable<Segment>, IDeepCloneable<Segment>, IBufferMessage
	{
		private static readonly MessageParser<Segment> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdFieldNumber = 1;

		private string id_;

		public const int NameFieldNumber = 2;

		private string name_;

		public const int PlatformFieldNumber = 3;

		private Platform platform_;

		public const int AppBundleIdFieldNumber = 4;

		private string appBundleId_;

		public const int ReceiversFieldNumber = 5;

		private static readonly FieldCodec<ReceiverNetwork> _repeated_receivers_codec;

		private readonly RepeatedField<ReceiverNetwork> receivers_;

		public const int EventConfigSetFieldNumber = 6;

		private EventConfigSet eventConfigSet_;

		public const int EnabledFieldNumber = 7;

		private bool enabled_;

		[DebuggerNonUserCode]
		public static MessageParser<Segment> Parser => null;

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
		public RepeatedField<ReceiverNetwork> Receivers => null;

		[DebuggerNonUserCode]
		public EventConfigSet EventConfigSet
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
		public bool Enabled
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
		public Segment()
		{
		}

		[DebuggerNonUserCode]
		public Segment(Segment other)
		{
		}

		[DebuggerNonUserCode]
		public Segment Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Segment other)
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
		public void MergeFrom(Segment other)
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

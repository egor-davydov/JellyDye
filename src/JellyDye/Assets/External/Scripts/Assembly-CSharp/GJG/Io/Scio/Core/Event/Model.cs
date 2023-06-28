using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Scio.Core.Event
{
	public sealed class Model : IMessage<Model>, IMessage, IEquatable<Model>, IDeepCloneable<Model>, IBufferMessage
	{
		private static readonly MessageParser<Model> _parser;

		private UnknownFieldSet _unknownFields;

		public const int EventIdFieldNumber = 1;

		private string eventId_;

		public const int SegmentIdFieldNumber = 2;

		private string segmentId_;

		public const int UserIdFieldNumber = 3;

		private string userId_;

		public const int CreatedAtFieldNumber = 4;

		private long createdAt_;

		public const int DataFieldNumber = 6;

		private static readonly MapField<string, string>.Codec _map_data_codec;

		private readonly MapField<string, string> data_;

		public const int DeviceIdFieldNumber = 7;

		private string deviceId_;

		public const int PlatformFieldNumber = 8;

		private string platform_;

		public const int AppBundleIdFieldNumber = 9;

		private string appBundleId_;

		public const int AdvertistingIdFieldNumber = 10;

		private string advertistingId_;

		public const int CountryFieldNumber = 11;

		private string country_;

		public const int IpAddressFieldNumber = 12;

		private string ipAddress_;

		[DebuggerNonUserCode]
		public static MessageParser<Model> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string EventId
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
		public string UserId
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
		public MapField<string, string> Data => null;

		[DebuggerNonUserCode]
		public string DeviceId
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
		public string Platform
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
		public string AdvertistingId
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
		public string Country
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
		public string IpAddress
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
		public Model()
		{
		}

		[DebuggerNonUserCode]
		public Model(Model other)
		{
		}

		[DebuggerNonUserCode]
		public Model Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Model other)
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
		public void MergeFrom(Model other)
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

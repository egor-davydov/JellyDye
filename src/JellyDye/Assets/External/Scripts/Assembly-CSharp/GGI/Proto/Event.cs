using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace GGI.Proto
{
	public sealed class Event : IMessage<Event>, IMessage, IEquatable<Event>, IDeepCloneable<Event>
	{
		private static readonly MessageParser<Event> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IDFieldNumber = 1;

		private string iD_;

		public const int TypeFieldNumber = 2;

		private string type_;

		public const int TimestampFieldNumber = 3;

		private long timestamp_;

		public const int UserIDFieldNumber = 4;

		private string userID_;

		public const int FirstEventTimestampFieldNumber = 5;

		private ulong firstEventTimestamp_;

		public const int PlatformFieldNumber = 6;

		private string platform_;

		public const int EventDataFieldNumber = 7;

		private static readonly MapField<string, string>.Codec _map_eventData_codec;

		private readonly MapField<string, string> eventData_;

		public const int UserPropertiesFieldNumber = 8;

		private static readonly MapField<string, string>.Codec _map_userProperties_codec;

		private readonly MapField<string, string> userProperties_;

		public const int DeviceFieldNumber = 9;

		private Device device_;

		public const int AppInfoFieldNumber = 10;

		private AppInfo appInfo_;

		public const int AttributionFieldNumber = 11;

		private AdjustAttribution attribution_;

		public const int LocationFieldNumber = 12;

		private Location location_;

		[DebuggerNonUserCode]
		public static MessageParser<Event> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string ID
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
		public string Type
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
		public long Timestamp
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
		public string UserID
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
		public ulong FirstEventTimestamp
		{
			get
			{
				return 0uL;
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
		public MapField<string, string> EventData => null;

		[DebuggerNonUserCode]
		public MapField<string, string> UserProperties => null;

		[DebuggerNonUserCode]
		public Device Device
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
		public AppInfo AppInfo
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
		public AdjustAttribution Attribution
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
		public Location Location
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
		public Event()
		{
		}

		[DebuggerNonUserCode]
		public Event(Event other)
		{
		}

		[DebuggerNonUserCode]
		public Event Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Event other)
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
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(Event other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}

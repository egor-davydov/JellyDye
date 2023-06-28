using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace GGI.Proto
{
	public sealed class Device : IMessage<Device>, IMessage, IEquatable<Device>, IDeepCloneable<Device>
	{
		private static readonly MessageParser<Device> _parser;

		private UnknownFieldSet _unknownFields;

		public const int DeviceIDFieldNumber = 1;

		private string deviceID_;

		public const int ModelFieldNumber = 2;

		private string model_;

		public const int OperatingSystemFieldNumber = 3;

		private string operatingSystem_;

		public const int OperatingSystemVersionFieldNumber = 4;

		private string operatingSystemVersion_;

		public const int LanguageFieldNumber = 5;

		private string language_;

		public const int WifiStateFieldNumber = 6;

		private string wifiState_;

		public const int CarrierFieldNumber = 7;

		private string carrier_;

		public const int LocaleFieldNumber = 8;

		private string locale_;

		public const int IsTabletFieldNumber = 9;

		private string isTablet_;

		public const int IPAddressFieldNumber = 10;

		private string iPAddress_;

		[DebuggerNonUserCode]
		public static MessageParser<Device> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string DeviceID
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
		public string Model
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
		public string OperatingSystem
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
		public string OperatingSystemVersion
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
		public string Language
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
		public string WifiState
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
		public string Carrier
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
		public string Locale
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
		public string IsTablet
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
		public string IPAddress
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
		public Device()
		{
		}

		[DebuggerNonUserCode]
		public Device(Device other)
		{
		}

		[DebuggerNonUserCode]
		public Device Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Device other)
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
		public void MergeFrom(Device other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}

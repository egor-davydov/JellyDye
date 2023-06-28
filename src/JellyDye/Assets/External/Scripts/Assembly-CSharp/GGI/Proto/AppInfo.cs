using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace GGI.Proto
{
	public sealed class AppInfo : IMessage<AppInfo>, IMessage, IEquatable<AppInfo>, IDeepCloneable<AppInfo>
	{
		private static readonly MessageParser<AppInfo> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IDFieldNumber = 1;

		private string iD_;

		public const int AppVersionFieldNumber = 2;

		private string appVersion_;

		public const int UnityVersionFieldNumber = 3;

		private string unityVersion_;

		public const int SdkVersionFieldNumber = 4;

		private string sdkVersion_;

		public const int GameIDFieldNumber = 5;

		private string gameID_;

		[DebuggerNonUserCode]
		public static MessageParser<AppInfo> Parser => null;

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
		public string AppVersion
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
		public string UnityVersion
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
		public string SdkVersion
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
		public string GameID
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
		public AppInfo()
		{
		}

		[DebuggerNonUserCode]
		public AppInfo(AppInfo other)
		{
		}

		[DebuggerNonUserCode]
		public AppInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AppInfo other)
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
		public void MergeFrom(AppInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}

using System;
using System.Diagnostics;
using Gjg.Io.Nimbus.Types;
using Gjg.Io.Wellknown.Type;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.App.V1
{
	public sealed class AppAdUnit : IMessage<AppAdUnit>, IMessage, IEquatable<AppAdUnit>, IDeepCloneable<AppAdUnit>, IBufferMessage
	{
		private static readonly MessageParser<AppAdUnit> _parser;

		private UnknownFieldSet _unknownFields;

		public const int PlatformFieldNumber = 1;

		private Platform platform_;

		public const int IdFieldNumber = 2;

		private string id_;

		public const int AdUnitFieldNumber = 3;

		private AdUnit adUnit_;

		public const int BundleIdFieldNumber = 4;

		private string bundleId_;

		[DebuggerNonUserCode]
		public static MessageParser<AppAdUnit> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

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
		public AdUnit AdUnit
		{
			get
			{
				return default(AdUnit);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string BundleId
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
		public AppAdUnit()
		{
		}

		[DebuggerNonUserCode]
		public AppAdUnit(AppAdUnit other)
		{
		}

		[DebuggerNonUserCode]
		public AppAdUnit Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AppAdUnit other)
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
		public void MergeFrom(AppAdUnit other)
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

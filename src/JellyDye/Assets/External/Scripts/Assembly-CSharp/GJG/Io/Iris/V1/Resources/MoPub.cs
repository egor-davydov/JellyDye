using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class MoPub : IMessage<MoPub>, IMessage, IEquatable<MoPub>, IDeepCloneable<MoPub>, IBufferMessage
	{
		private static readonly MessageParser<MoPub> _parser;

		private UnknownFieldSet _unknownFields;

		public const int AppKeyFieldNumber = 1;

		private string appKey_;

		public const int AdUnitsFieldNumber = 2;

		private static readonly MapField<string, MoPubAdUnit>.Codec _map_adUnits_codec;

		private readonly MapField<string, MoPubAdUnit> adUnits_;

		[DebuggerNonUserCode]
		public static MessageParser<MoPub> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string AppKey
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
		public MapField<string, MoPubAdUnit> AdUnits => null;

		[DebuggerNonUserCode]
		public MoPub()
		{
		}

		[DebuggerNonUserCode]
		public MoPub(MoPub other)
		{
		}

		[DebuggerNonUserCode]
		public MoPub Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MoPub other)
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
		public void MergeFrom(MoPub other)
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

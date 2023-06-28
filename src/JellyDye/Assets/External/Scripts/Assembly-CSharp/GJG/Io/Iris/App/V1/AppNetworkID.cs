using System;
using System.Diagnostics;
using Gjg.Io.Nimbus.Types;
using Gjg.Io.Wellknown.Type;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.App.V1
{
	public sealed class AppNetworkID : IMessage<AppNetworkID>, IMessage, IEquatable<AppNetworkID>, IDeepCloneable<AppNetworkID>, IBufferMessage
	{
		private static readonly MessageParser<AppNetworkID> _parser;

		private UnknownFieldSet _unknownFields;

		public const int NetworkFieldNumber = 1;

		private Network network_;

		public const int PlatformFieldNumber = 2;

		private Platform platform_;

		public const int BundleIdFieldNumber = 3;

		private string bundleId_;

		public const int IdsFieldNumber = 4;

		private static readonly FieldCodec<string> _repeated_ids_codec;

		private readonly RepeatedField<string> ids_;

		[DebuggerNonUserCode]
		public static MessageParser<AppNetworkID> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public Network Network
		{
			get
			{
				return default(Network);
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
		public RepeatedField<string> Ids => null;

		[DebuggerNonUserCode]
		public AppNetworkID()
		{
		}

		[DebuggerNonUserCode]
		public AppNetworkID(AppNetworkID other)
		{
		}

		[DebuggerNonUserCode]
		public AppNetworkID Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AppNetworkID other)
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
		public void MergeFrom(AppNetworkID other)
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

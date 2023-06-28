using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Resources
{
	public sealed class CloudbuildUnityVersion : IMessage<CloudbuildUnityVersion>, IMessage, IEquatable<CloudbuildUnityVersion>, IDeepCloneable<CloudbuildUnityVersion>, IBufferMessage
	{
		private static readonly MessageParser<CloudbuildUnityVersion> _parser;

		private UnknownFieldSet _unknownFields;

		public const int IdFieldNumber = 1;

		private string id_;

		public const int VersionsFieldNumber = 2;

		private static readonly FieldCodec<string> _repeated_versions_codec;

		private readonly RepeatedField<string> versions_;

		[DebuggerNonUserCode]
		public static MessageParser<CloudbuildUnityVersion> Parser => null;

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
		public RepeatedField<string> Versions => null;

		[DebuggerNonUserCode]
		public CloudbuildUnityVersion()
		{
		}

		[DebuggerNonUserCode]
		public CloudbuildUnityVersion(CloudbuildUnityVersion other)
		{
		}

		[DebuggerNonUserCode]
		public CloudbuildUnityVersion Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CloudbuildUnityVersion other)
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
		public void MergeFrom(CloudbuildUnityVersion other)
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

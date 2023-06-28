using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Gjg.Io.Iris.V1.Services
{
	public sealed class CloudbuildYAMLResponse : IMessage<CloudbuildYAMLResponse>, IMessage, IEquatable<CloudbuildYAMLResponse>, IDeepCloneable<CloudbuildYAMLResponse>, IBufferMessage
	{
		private static readonly MessageParser<CloudbuildYAMLResponse> _parser;

		private UnknownFieldSet _unknownFields;

		public const int YamlFieldNumber = 1;

		private string yaml_;

		public const int ProvisionProfileNameFieldNumber = 2;

		private string provisionProfileName_;

		[DebuggerNonUserCode]
		public static MessageParser<CloudbuildYAMLResponse> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string Yaml
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
		public string ProvisionProfileName
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
		public CloudbuildYAMLResponse()
		{
		}

		[DebuggerNonUserCode]
		public CloudbuildYAMLResponse(CloudbuildYAMLResponse other)
		{
		}

		[DebuggerNonUserCode]
		public CloudbuildYAMLResponse Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CloudbuildYAMLResponse other)
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
		public void MergeFrom(CloudbuildYAMLResponse other)
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

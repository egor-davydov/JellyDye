using System;
using System.Diagnostics;

namespace Google.Protobuf.Reflection
{
	public sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IMessage, IEquatable<MethodDescriptorProto>, IDeepCloneable<MethodDescriptorProto>, IBufferMessage
	{
		private static readonly MessageParser<MethodDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private int _hasBits0;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly string InputTypeDefaultValue;

		private string inputType_;

		private static readonly string OutputTypeDefaultValue;

		private string outputType_;

		private MethodOptions options_;

		private static readonly bool ClientStreamingDefaultValue;

		private bool clientStreaming_;

		private static readonly bool ServerStreamingDefaultValue;

		private bool serverStreaming_;

		[DebuggerNonUserCode]
		public static MessageParser<MethodDescriptorProto> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

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
		public bool HasName => false;

		[DebuggerNonUserCode]
		public string InputType
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
		public bool HasInputType => false;

		[DebuggerNonUserCode]
		public string OutputType
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
		public bool HasOutputType => false;

		[DebuggerNonUserCode]
		public MethodOptions Options
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
		public bool ClientStreaming
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
		public bool HasClientStreaming => false;

		[DebuggerNonUserCode]
		public bool ServerStreaming
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
		public bool HasServerStreaming => false;

		[DebuggerNonUserCode]
		public MethodDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public MethodDescriptorProto(MethodDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public MethodDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MethodDescriptorProto other)
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
		public void MergeFrom(MethodDescriptorProto other)
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

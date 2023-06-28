using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IMessage, IEquatable<FileDescriptorProto>, IDeepCloneable<FileDescriptorProto>, IBufferMessage
	{
		private static readonly MessageParser<FileDescriptorProto> _parser;

		private UnknownFieldSet _unknownFields;

		private static readonly string NameDefaultValue;

		private string name_;

		private static readonly string PackageDefaultValue;

		private string package_;

		private static readonly FieldCodec<string> _repeated_dependency_codec;

		private readonly RepeatedField<string> dependency_;

		private static readonly FieldCodec<int> _repeated_publicDependency_codec;

		private readonly RepeatedField<int> publicDependency_;

		private static readonly FieldCodec<int> _repeated_weakDependency_codec;

		private readonly RepeatedField<int> weakDependency_;

		private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec;

		private readonly RepeatedField<DescriptorProto> messageType_;

		private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec;

		private readonly RepeatedField<EnumDescriptorProto> enumType_;

		private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec;

		private readonly RepeatedField<ServiceDescriptorProto> service_;

		private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec;

		private readonly RepeatedField<FieldDescriptorProto> extension_;

		private FileOptions options_;

		private SourceCodeInfo sourceCodeInfo_;

		private static readonly string SyntaxDefaultValue;

		private string syntax_;

		[DebuggerNonUserCode]
		public static MessageParser<FileDescriptorProto> Parser => null;

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
		public string Package
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
		public bool HasPackage => false;

		[DebuggerNonUserCode]
		public RepeatedField<string> Dependency => null;

		[DebuggerNonUserCode]
		public RepeatedField<int> PublicDependency => null;

		[DebuggerNonUserCode]
		public RepeatedField<DescriptorProto> MessageType => null;

		[DebuggerNonUserCode]
		public RepeatedField<EnumDescriptorProto> EnumType => null;

		[DebuggerNonUserCode]
		public RepeatedField<ServiceDescriptorProto> Service => null;

		[DebuggerNonUserCode]
		public RepeatedField<FieldDescriptorProto> Extension => null;

		[DebuggerNonUserCode]
		public FileOptions Options
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
		public SourceCodeInfo SourceCodeInfo
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
		public string Syntax
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
		public bool HasSyntax => false;

		[DebuggerNonUserCode]
		public FileDescriptorProto()
		{
		}

		[DebuggerNonUserCode]
		public FileDescriptorProto(FileDescriptorProto other)
		{
		}

		[DebuggerNonUserCode]
		public FileDescriptorProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FileDescriptorProto other)
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
		public void MergeFrom(FileDescriptorProto other)
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

using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	public sealed class FileOptions : IExtendableMessage<FileOptions>, IMessage<FileOptions>, IMessage, IEquatable<FileOptions>, IDeepCloneable<FileOptions>, IBufferMessage
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public enum OptimizeMode
			{
				Speed = 1,
				CodeSize = 2,
				LiteRuntime = 3
			}
		}

		private static readonly MessageParser<FileOptions> _parser;

		private UnknownFieldSet _unknownFields;

		internal ExtensionSet<FileOptions> _extensions;

		private int _hasBits0;

		private static readonly string JavaPackageDefaultValue;

		private string javaPackage_;

		private static readonly string JavaOuterClassnameDefaultValue;

		private string javaOuterClassname_;

		private static readonly bool JavaMultipleFilesDefaultValue;

		private bool javaMultipleFiles_;

		private static readonly bool JavaGenerateEqualsAndHashDefaultValue;

		private bool javaGenerateEqualsAndHash_;

		private static readonly bool JavaStringCheckUtf8DefaultValue;

		private bool javaStringCheckUtf8_;

		private static readonly Types.OptimizeMode OptimizeForDefaultValue;

		private Types.OptimizeMode optimizeFor_;

		private static readonly string GoPackageDefaultValue;

		private string goPackage_;

		private static readonly bool CcGenericServicesDefaultValue;

		private bool ccGenericServices_;

		private static readonly bool JavaGenericServicesDefaultValue;

		private bool javaGenericServices_;

		private static readonly bool PyGenericServicesDefaultValue;

		private bool pyGenericServices_;

		private static readonly bool PhpGenericServicesDefaultValue;

		private bool phpGenericServices_;

		private static readonly bool DeprecatedDefaultValue;

		private bool deprecated_;

		private static readonly bool CcEnableArenasDefaultValue;

		private bool ccEnableArenas_;

		private static readonly string ObjcClassPrefixDefaultValue;

		private string objcClassPrefix_;

		private static readonly string CsharpNamespaceDefaultValue;

		private string csharpNamespace_;

		private static readonly string SwiftPrefixDefaultValue;

		private string swiftPrefix_;

		private static readonly string PhpClassPrefixDefaultValue;

		private string phpClassPrefix_;

		private static readonly string PhpNamespaceDefaultValue;

		private string phpNamespace_;

		private static readonly string PhpMetadataNamespaceDefaultValue;

		private string phpMetadataNamespace_;

		private static readonly string RubyPackageDefaultValue;

		private string rubyPackage_;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		public static MessageParser<FileOptions> Parser => null;

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor => null;

		[DebuggerNonUserCode]
		private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor => null;

		[DebuggerNonUserCode]
		public string JavaPackage
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
		public bool HasJavaPackage => false;

		[DebuggerNonUserCode]
		public string JavaOuterClassname
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
		public bool HasJavaOuterClassname => false;

		[DebuggerNonUserCode]
		public bool JavaMultipleFiles
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
		public bool HasJavaMultipleFiles => false;

		[DebuggerNonUserCode]
		[Obsolete]
		public bool JavaGenerateEqualsAndHash
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
		[Obsolete]
		public bool HasJavaGenerateEqualsAndHash => false;

		[DebuggerNonUserCode]
		public bool JavaStringCheckUtf8
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
		public bool HasJavaStringCheckUtf8 => false;

		[DebuggerNonUserCode]
		public Types.OptimizeMode OptimizeFor
		{
			get
			{
				return default(Types.OptimizeMode);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool HasOptimizeFor => false;

		[DebuggerNonUserCode]
		public string GoPackage
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
		public bool HasGoPackage => false;

		[DebuggerNonUserCode]
		public bool CcGenericServices
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
		public bool HasCcGenericServices => false;

		[DebuggerNonUserCode]
		public bool JavaGenericServices
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
		public bool HasJavaGenericServices => false;

		[DebuggerNonUserCode]
		public bool PyGenericServices
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
		public bool HasPyGenericServices => false;

		[DebuggerNonUserCode]
		public bool PhpGenericServices
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
		public bool HasPhpGenericServices => false;

		[DebuggerNonUserCode]
		public bool Deprecated
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
		public bool HasDeprecated => false;

		[DebuggerNonUserCode]
		public bool CcEnableArenas
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
		public bool HasCcEnableArenas => false;

		[DebuggerNonUserCode]
		public string ObjcClassPrefix
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
		public bool HasObjcClassPrefix => false;

		[DebuggerNonUserCode]
		public string CsharpNamespace
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
		public bool HasCsharpNamespace => false;

		[DebuggerNonUserCode]
		public string SwiftPrefix
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
		public bool HasSwiftPrefix => false;

		[DebuggerNonUserCode]
		public string PhpClassPrefix
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
		public bool HasPhpClassPrefix => false;

		[DebuggerNonUserCode]
		public string PhpNamespace
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
		public bool HasPhpNamespace => false;

		[DebuggerNonUserCode]
		public string PhpMetadataNamespace
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
		public bool HasPhpMetadataNamespace => false;

		[DebuggerNonUserCode]
		public string RubyPackage
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
		public bool HasRubyPackage => false;

		[DebuggerNonUserCode]
		public FileOptions()
		{
		}

		[DebuggerNonUserCode]
		public FileOptions(FileOptions other)
		{
		}

		[DebuggerNonUserCode]
		public FileOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FileOptions other)
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
		public void MergeFrom(FileOptions other)
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

		public TValue GetExtension<TValue>(Extension<FileOptions, TValue> extension)
		{
			return default(TValue);
		}

		public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension)
		{
			return null;
		}

		public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension)
		{
			return null;
		}

		public bool HasExtension<TValue>(Extension<FileOptions, TValue> extension)
		{
			return false;
		}

		public void ClearExtension<TValue>(Extension<FileOptions, TValue> extension)
		{
		}
	}
}

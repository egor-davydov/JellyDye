using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class FileDescriptor : IDescriptor
	{
		private readonly Lazy<Dictionary<IDescriptor, DescriptorDeclaration>> declarations;

		internal FileDescriptorProto Proto
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Syntax Syntax
		{
			[CompilerGenerated]
			get
			{
				return default(Syntax);
			}
		}

		public string Name => null;

		public string Package => null;

		public IList<MessageDescriptor> MessageTypes
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public IList<EnumDescriptor> EnumTypes
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public IList<ServiceDescriptor> Services
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ExtensionCollection Extensions
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public IList<FileDescriptor> Dependencies
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public IList<FileDescriptor> PublicDependencies
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		private string Google_002EProtobuf_002EReflection_002EIDescriptor_002EFullName => null;

		private FileDescriptor Google_002EProtobuf_002EReflection_002EIDescriptor_002EFile => null;

		internal DescriptorPool DescriptorPool
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		static FileDescriptor()
		{
		}

		private FileDescriptor(ByteString descriptorData, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
		}

		private Dictionary<IDescriptor, DescriptorDeclaration> CreateDeclarationMap()
		{
			return null;
		}

		private IDescriptor FindDescriptorForPath(IList<int> path)
		{
			return null;
		}

		private DescriptorBase GetDescriptorFromList(IReadOnlyList<DescriptorBase> list, int index)
		{
			return null;
		}

		private IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}

		internal string ComputeFullName(MessageDescriptor parent, string name)
		{
			return null;
		}

		private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor @this, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, bool allowUnknownDependencies)
		{
			return null;
		}

		private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			return null;
		}

		private void CrossLink()
		{
		}

		public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo)
		{
			return null;
		}

		private static IEnumerable<Extension> GetAllExtensions(FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedInfo)
		{
			return null;
		}

		private static IEnumerable<Extension> GetAllGeneratedExtensions(GeneratedClrTypeInfo generated)
		{
			return null;
		}

		private static IEnumerable<Extension> GetAllDependedExtensions(FileDescriptor descriptor)
		{
			return null;
		}

		private static IEnumerable<Extension> GetAllDependedExtensionsFromMessage(MessageDescriptor descriptor)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static void ForceReflectionInitialization<T>()
		{
		}
	}
}

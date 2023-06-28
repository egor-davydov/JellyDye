using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class MessageDescriptor : DescriptorBase
	{
		public sealed class FieldCollection
		{
			private readonly MessageDescriptor messageDescriptor;

			public FieldDescriptor Item => null;

			internal FieldCollection(MessageDescriptor messageDescriptor)
			{
			}

			public IList<FieldDescriptor> InDeclarationOrder()
			{
				return null;
			}

			public IList<FieldDescriptor> InFieldNumberOrder()
			{
				return null;
			}
		}

		private static readonly HashSet<string> WellKnownTypeNames;

		private readonly IList<FieldDescriptor> fieldsInDeclarationOrder;

		private readonly IList<FieldDescriptor> fieldsInNumberOrder;

		private readonly IDictionary<string, FieldDescriptor> jsonFieldMap;

		public override string Name => null;

		internal DescriptorProto Proto
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Type ClrType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public MessageParser Parser
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal bool IsWellKnownType => false;

		internal bool IsWrapperType => false;

		public FieldCollection Fields
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

		public IList<MessageDescriptor> NestedTypes
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

		public IList<OneofDescriptor> Oneofs
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		internal MessageDescriptor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo)
			: base(null, null, 0)
		{
		}

		private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields)
		{
			return null;
		}

		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}

		public FieldDescriptor FindFieldByNumber(int number)
		{
			return null;
		}

		internal void CrossLink()
		{
		}
	}
}

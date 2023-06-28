using System;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor>
	{
		private EnumDescriptor enumType;

		private MessageDescriptor extendeeType;

		private MessageDescriptor messageType;

		private FieldType fieldType;

		private readonly string propertyName;

		private IFieldAccessor accessor;

		public MessageDescriptor ContainingType
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public OneofDescriptor ContainingOneof
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public OneofDescriptor RealContainingOneof => null;

		public string JsonName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public bool HasPresence => false;

		internal FieldDescriptorProto Proto
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Extension Extension
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public override string Name => null;

		public IFieldAccessor Accessor => null;

		public bool IsRepeated => false;

		public bool IsMap => false;

		public FieldType FieldType => default(FieldType);

		public int FieldNumber => 0;

		public MessageDescriptor ExtendeeType => null;

		internal FieldDescriptor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName, Extension extension)
			: base(null, null, 0)
		{
		}

		private static FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type)
		{
			return default(FieldType);
		}

		public int CompareTo(FieldDescriptor other)
		{
			return 0;
		}

		internal void CrossLink()
		{
		}

		private IFieldAccessor CreateAccessor()
		{
			return null;
		}
	}
}

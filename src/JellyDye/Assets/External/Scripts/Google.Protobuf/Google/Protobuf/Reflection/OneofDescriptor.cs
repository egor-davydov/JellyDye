using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	public sealed class OneofDescriptor : DescriptorBase
	{
		private readonly OneofDescriptorProto proto;

		private MessageDescriptor containingType;

		private IList<FieldDescriptor> fields;

		private readonly OneofAccessor accessor;

		public override string Name => null;

		public MessageDescriptor ContainingType => null;

		public IList<FieldDescriptor> Fields => null;

		public bool IsSynthetic
		{
			[CompilerGenerated]
			get
			{
				return false;
			}
		}

		public OneofAccessor Accessor => null;

		internal OneofDescriptor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName)
			: base(null, null, 0)
		{
		}

		internal void CrossLink()
		{
		}

		private OneofAccessor CreateAccessor(string clrName)
		{
			return null;
		}
	}
}

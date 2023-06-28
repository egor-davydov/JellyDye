using System;
using System.Collections.Generic;

namespace Google.Protobuf.Reflection
{
	public sealed class EnumDescriptor : DescriptorBase
	{
		private readonly EnumDescriptorProto proto;

		private readonly MessageDescriptor containingType;

		private readonly IList<EnumValueDescriptor> values;

		private readonly Type clrType;

		public override string Name => null;

		public IList<EnumValueDescriptor> Values => null;

		internal EnumDescriptor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, Type clrType)
			: base(null, null, 0)
		{
		}

		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}
	}
}

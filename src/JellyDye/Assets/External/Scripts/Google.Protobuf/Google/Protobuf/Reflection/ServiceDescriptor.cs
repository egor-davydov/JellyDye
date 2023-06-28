using System.Collections.Generic;

namespace Google.Protobuf.Reflection
{
	public sealed class ServiceDescriptor : DescriptorBase
	{
		private readonly ServiceDescriptorProto proto;

		private readonly IList<MethodDescriptor> methods;

		public override string Name => null;

		internal ServiceDescriptor(ServiceDescriptorProto proto, FileDescriptor file, int index)
			: base(null, null, 0)
		{
		}

		internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber)
		{
			return null;
		}

		internal void CrossLink()
		{
		}
	}
}

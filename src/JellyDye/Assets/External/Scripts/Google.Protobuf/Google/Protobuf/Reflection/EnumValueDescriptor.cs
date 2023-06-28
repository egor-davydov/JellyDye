namespace Google.Protobuf.Reflection
{
	public sealed class EnumValueDescriptor : DescriptorBase
	{
		private readonly EnumDescriptor enumDescriptor;

		private readonly EnumValueDescriptorProto proto;

		internal EnumValueDescriptorProto Proto => null;

		public override string Name => null;

		public int Number => 0;

		public EnumDescriptor EnumDescriptor => null;

		internal EnumValueDescriptor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index)
			: base(null, null, 0)
		{
		}
	}
}

namespace Google.Protobuf.Reflection
{
	public sealed class MethodDescriptor : DescriptorBase
	{
		private readonly MethodDescriptorProto proto;

		private readonly ServiceDescriptor service;

		private MessageDescriptor inputType;

		private MessageDescriptor outputType;

		internal MethodDescriptorProto Proto => null;

		public override string Name => null;

		internal MethodDescriptor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index)
			: base(null, null, 0)
		{
		}

		internal void CrossLink()
		{
		}
	}
}

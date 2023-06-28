namespace Google.Protobuf.Reflection
{
	internal sealed class PackageDescriptor : IDescriptor
	{
		private readonly string name;

		private readonly string fullName;

		private readonly FileDescriptor file;

		public string Name => null;

		public string FullName => null;

		public FileDescriptor File => null;

		internal PackageDescriptor(string name, string fullName, FileDescriptor file)
		{
		}
	}
}

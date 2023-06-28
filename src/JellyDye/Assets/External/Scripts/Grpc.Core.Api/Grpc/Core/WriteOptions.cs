namespace Grpc.Core
{
	public class WriteOptions
	{
		public static readonly WriteOptions Default;

		private readonly WriteFlags flags;

		public WriteFlags Flags => default(WriteFlags);

		public WriteOptions(WriteFlags flags = (WriteFlags)0)
		{
		}
	}
}

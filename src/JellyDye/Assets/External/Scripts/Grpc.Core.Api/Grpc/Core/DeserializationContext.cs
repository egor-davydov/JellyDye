using System.Buffers;

namespace Grpc.Core
{
	public abstract class DeserializationContext
	{
		public virtual byte[] PayloadAsNewBuffer()
		{
			return null;
		}

		public virtual ReadOnlySequence<byte> PayloadAsReadOnlySequence()
		{
			return default(ReadOnlySequence<byte>);
		}
	}
}

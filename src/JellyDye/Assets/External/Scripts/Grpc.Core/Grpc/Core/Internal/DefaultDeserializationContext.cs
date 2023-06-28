using System.Buffers;
using System.Threading;

namespace Grpc.Core.Internal
{
	internal class DefaultDeserializationContext : DeserializationContext
	{
		private static readonly ThreadLocal<DefaultDeserializationContext> threadLocalInstance;

		private IBufferReader bufferReader;

		private int payloadLength;

		private ReusableSliceBuffer cachedSliceBuffer;

		public override byte[] PayloadAsNewBuffer()
		{
			return null;
		}

		public override ReadOnlySequence<byte> PayloadAsReadOnlySequence()
		{
			return default(ReadOnlySequence<byte>);
		}

		public void Initialize(IBufferReader bufferReader)
		{
		}

		public void Reset()
		{
		}

		public static DefaultDeserializationContext GetInitializedThreadLocal(IBufferReader bufferReader)
		{
			return null;
		}
	}
}

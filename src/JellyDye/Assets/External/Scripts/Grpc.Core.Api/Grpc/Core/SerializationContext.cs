using System.Buffers;

namespace Grpc.Core
{
	public abstract class SerializationContext
	{
		public virtual void Complete(byte[] payload)
		{
		}

		public virtual IBufferWriter<byte> GetBufferWriter()
		{
			return null;
		}

		public virtual void SetPayloadLength(int payloadLength)
		{
		}

		public virtual void Complete()
		{
		}
	}
}

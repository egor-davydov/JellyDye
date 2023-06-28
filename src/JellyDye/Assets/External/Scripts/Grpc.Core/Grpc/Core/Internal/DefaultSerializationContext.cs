using System;
using System.Buffers;
using System.Threading;

namespace Grpc.Core.Internal
{
	internal class DefaultSerializationContext : SerializationContext
	{
		public struct UsageScope : IDisposable
		{
			private readonly DefaultSerializationContext context;

			public DefaultSerializationContext Context => null;

			public UsageScope(DefaultSerializationContext context)
			{
			}

			public void Dispose()
			{
			}
		}

		private static readonly ThreadLocal<DefaultSerializationContext> threadLocalInstance;

		private bool isComplete;

		private SliceBufferSafeHandle sliceBuffer;

		public override void Complete(byte[] payload)
		{
		}

		public override IBufferWriter<byte> GetBufferWriter()
		{
			return null;
		}

		public override void SetPayloadLength(int payloadLength)
		{
		}

		public override void Complete()
		{
		}

		internal SliceBufferSafeHandle GetPayload()
		{
			return null;
		}

		public void Reset()
		{
		}

		public static UsageScope GetInitializedThreadLocalScope()
		{
			return default(UsageScope);
		}
	}
}

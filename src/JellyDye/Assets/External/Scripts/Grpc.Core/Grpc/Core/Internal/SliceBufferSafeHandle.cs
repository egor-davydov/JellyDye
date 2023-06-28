using System;
using System.Buffers;
using Grpc.Core.Logging;

namespace Grpc.Core.Internal
{
	internal class SliceBufferSafeHandle : SafeHandleZeroIsInvalid, IBufferWriter<byte>
	{
		private static readonly NativeMethods Native;

		private static readonly ILogger Logger;

		public static readonly SliceBufferSafeHandle NullInstance;

		private IntPtr tailSpacePtr;

		private int tailSpaceLen;

		private SliceMemoryManager memoryManagerLazy;

		private SliceBufferSafeHandle()
		{
		}

		public static SliceBufferSafeHandle Create()
		{
			return null;
		}

		public void Advance(int count)
		{
		}

		public Span<byte> GetSpan(int sizeHint = 0)
		{
			return default(Span<byte>);
		}

		public void Complete()
		{
		}

		public void Reset()
		{
		}

		private void EnsureBufferSpace(int sizeHint)
		{
		}

		private void AdjustTailSpace(int requestedSize)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}

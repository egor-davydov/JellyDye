using System;

namespace Grpc.Core.Internal
{
	internal struct Slice
	{
		private readonly IntPtr dataPtr;

		private readonly int length;

		public int Length => 0;

		public Slice(IntPtr dataPtr, int length)
		{
		}

		public Span<byte> ToSpanUnsafe()
		{
			return default(Span<byte>);
		}

		public override string ToString()
		{
			return null;
		}
	}
}

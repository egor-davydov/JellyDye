using System;
using System.Buffers;

namespace Grpc.Core.Internal
{
	internal class SliceMemoryManager : MemoryManager<byte>
	{
		private Slice slice;

		public void Reset(Slice slice)
		{
		}

		public void Reset()
		{
		}

		public override Span<byte> GetSpan()
		{
			return default(Span<byte>);
		}

		protected override void Dispose(bool disposing)
		{
		}

		public SliceMemoryManager()
		{
			((MemoryManager<T>)(object)this)._002Ector();
		}
	}
}

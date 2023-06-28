using System.Buffers;

namespace Grpc.Core.Internal
{
	internal class ReusableSliceBuffer
	{
		private class SliceSegment : ReadOnlySequenceSegment<byte>
		{
			private readonly SliceMemoryManager pointerMemoryManager;

			public void Reset(Slice slice, long runningIndex)
			{
			}

			public void SetNext(ReadOnlySequenceSegment<byte> next)
			{
			}

			public SliceSegment()
			{
				((ReadOnlySequenceSegment<T>)(object)this)._002Ector();
			}
		}

		private readonly SliceSegment[] cachedSegments;

		private int populatedSegmentCount;

		public ReadOnlySequence<byte> PopulateFrom(IBufferReader bufferReader)
		{
			return default(ReadOnlySequence<byte>);
		}

		public void Invalidate()
		{
		}
	}
}

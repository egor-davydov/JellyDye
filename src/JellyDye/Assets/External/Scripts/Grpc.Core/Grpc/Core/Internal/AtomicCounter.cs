namespace Grpc.Core.Internal
{
	internal class AtomicCounter
	{
		private long counter;

		public long Count => 0L;

		public AtomicCounter(long initialCount = 0L)
		{
		}

		public long Increment()
		{
			return 0L;
		}

		public void IncrementIfNonzero(ref bool success)
		{
		}

		public long Decrement()
		{
			return 0L;
		}
	}
}

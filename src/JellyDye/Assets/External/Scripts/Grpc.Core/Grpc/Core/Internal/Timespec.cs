using System;

namespace Grpc.Core.Internal
{
	internal struct Timespec : IEquatable<Timespec>
	{
		private const long NanosPerSecond = 1000000000L;

		private const long NanosPerTick = 100L;

		private const long TicksPerSecond = 10000000L;

		private static readonly NativeMethods Native;

		private static readonly DateTime UnixEpoch;

		private long tv_sec;

		private int tv_nsec;

		private ClockType clock_type;

		public static Timespec InfFuture => default(Timespec);

		public static Timespec InfPast => default(Timespec);

		public long TimevalSeconds => 0L;

		public int TimevalNanos => 0;

		internal static Timespec PreciseNow => default(Timespec);

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public bool Equals(Timespec other)
		{
			return false;
		}

		public Timespec(long tv_sec, int tv_nsec)
		{
		}

		public Timespec(long tv_sec, int tv_nsec, ClockType clock_type)
		{
		}

		public static Timespec FromDateTime(DateTime dateTime)
		{
			return default(Timespec);
		}
	}
}

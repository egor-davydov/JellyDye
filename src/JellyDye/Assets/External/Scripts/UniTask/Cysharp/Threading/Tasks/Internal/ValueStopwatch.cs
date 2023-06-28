using System;

namespace Cysharp.Threading.Tasks.Internal
{
	internal readonly struct ValueStopwatch
	{
		private static readonly double TimestampToTicks;

		private readonly long startTimestamp;

		public TimeSpan Elapsed => default(TimeSpan);

		public bool IsInvalid => false;

		public long ElapsedTicks => 0L;

		public static ValueStopwatch StartNew()
		{
			return default(ValueStopwatch);
		}

		private ValueStopwatch(long startTimestamp)
		{
		}
	}
}

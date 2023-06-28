using System;
using System.Threading;
using System.Threading.Tasks;

namespace Polly.Utilities
{
	public static class SystemClock
	{
		public static Action<TimeSpan, CancellationToken> Sleep;

		public static Func<TimeSpan, CancellationToken, Task> SleepAsync;

		public static Func<DateTime> UtcNow;

		public static Func<DateTimeOffset> DateTimeOffsetUtcNow;

		public static Action<CancellationTokenSource, TimeSpan> CancelTokenAfter;
	}
}

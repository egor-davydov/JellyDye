using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace IdGen
{
	public abstract class StopwatchTimeSource : ITimeSource
	{
		private static readonly Stopwatch _sw;

		private static readonly DateTimeOffset _initialized;

		public DateTimeOffset Epoch
		{
			[CompilerGenerated]
			get
			{
				return default(DateTimeOffset);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		protected static TimeSpan Elapsed => default(TimeSpan);

		protected TimeSpan Offset
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public TimeSpan TickDuration
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public StopwatchTimeSource(DateTimeOffset epoch, TimeSpan tickDuration)
		{
		}

		public abstract long GetTicks();
	}
}

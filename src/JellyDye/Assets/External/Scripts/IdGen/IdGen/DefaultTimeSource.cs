using System;

namespace IdGen
{
	public class DefaultTimeSource : StopwatchTimeSource
	{
		public DefaultTimeSource(DateTimeOffset epoch)
			: base(default(DateTimeOffset), default(TimeSpan))
		{
		}

		public DefaultTimeSource(DateTimeOffset epoch, TimeSpan tickDuration)
			: base(default(DateTimeOffset), default(TimeSpan))
		{
		}

		public override long GetTicks()
		{
			return 0L;
		}
	}
}

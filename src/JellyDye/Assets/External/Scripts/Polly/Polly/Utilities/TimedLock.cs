using System;

namespace Polly.Utilities
{
	internal struct TimedLock : IDisposable
	{
		private static readonly TimeSpan LockTimeout;

		private object target;

		public static TimedLock Lock(object o)
		{
			return default(TimedLock);
		}

		private static TimedLock Lock(object o, TimeSpan timeout)
		{
			return default(TimedLock);
		}

		private TimedLock(object o)
		{
		}

		public void Dispose()
		{
		}
	}
}

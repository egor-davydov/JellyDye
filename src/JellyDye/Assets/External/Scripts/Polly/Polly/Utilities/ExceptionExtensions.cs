using System;

namespace Polly.Utilities
{
	public static class ExceptionExtensions
	{
		public static void RethrowWithOriginalStackTraceIfDiffersFrom(this Exception exceptionPossiblyToThrow, Exception exceptionToCompare)
		{
		}
	}
}

using System;

namespace Polly
{
	public class PolicyResult
	{
		internal PolicyResult(OutcomeType outcome, Exception finalException, ExceptionType? exceptionType, Context context)
		{
		}

		public static PolicyResult Successful(Context context)
		{
			return null;
		}

		public static PolicyResult Failure(Exception exception, ExceptionType exceptionType, Context context)
		{
			return null;
		}
	}
}

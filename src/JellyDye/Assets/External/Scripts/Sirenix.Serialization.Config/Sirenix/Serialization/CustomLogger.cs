using System;

namespace Sirenix.Serialization
{
	public class CustomLogger : ILogger
	{
		private Action<string> logWarningDelegate;

		private Action<string> logErrorDelegate;

		private Action<Exception> logExceptionDelegate;

		public CustomLogger(Action<string> logWarningDelegate, Action<string> logErrorDelegate, Action<Exception> logExceptionDelegate)
		{
		}

		public void LogWarning(string warning)
		{
		}

		public void LogError(string error)
		{
		}

		public void LogException(Exception exception)
		{
		}
	}
}

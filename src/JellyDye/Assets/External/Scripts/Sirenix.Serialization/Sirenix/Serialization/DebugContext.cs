using System;

namespace Sirenix.Serialization
{
	public sealed class DebugContext
	{
		private readonly object LOCK;

		private ILogger logger;

		private LoggingPolicy loggingPolicy;

		private ErrorHandlingPolicy errorHandlingPolicy;

		public ILogger Logger
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LoggingPolicy LoggingPolicy
		{
			get
			{
				return default(LoggingPolicy);
			}
			set
			{
			}
		}

		public ErrorHandlingPolicy ErrorHandlingPolicy
		{
			get
			{
				return default(ErrorHandlingPolicy);
			}
			set
			{
			}
		}

		public void LogWarning(string message)
		{
		}

		public void LogError(string message)
		{
		}

		public void LogException(Exception exception)
		{
		}

		public void ResetToDefault()
		{
		}
	}
}

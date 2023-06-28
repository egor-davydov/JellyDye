using System;

namespace Grpc.Core.Logging
{
	public class LogLevelFilterLogger : ILogger
	{
		private readonly ILogger innerLogger;

		private readonly LogLevel logLevel;

		public LogLevelFilterLogger(ILogger logger, LogLevel logLevel)
		{
		}

		public LogLevelFilterLogger(ILogger logger, LogLevel defaultLogLevel, bool fromEnvironmentVariable)
		{
		}

		public virtual ILogger ForType<T>()
		{
			return null;
		}

		public void Debug(string message)
		{
		}

		public void Debug(string format, params object[] formatArgs)
		{
		}

		public void Info(string message)
		{
		}

		public void Warning(string format, params object[] formatArgs)
		{
		}

		public void Error(string message)
		{
		}

		public void Error(Exception exception, string message)
		{
		}

		private static LogLevel GetLogLevelFromEnvironment(LogLevel defaultLogLevel, bool fromEnvironmentVariable)
		{
			return default(LogLevel);
		}
	}
}

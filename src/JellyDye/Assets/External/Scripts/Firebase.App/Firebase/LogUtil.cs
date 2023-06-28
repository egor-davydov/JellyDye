using System;
using Firebase.Platform;

namespace Firebase
{
	internal sealed class LogUtil : IDisposable
	{
		internal delegate void LogMessageDelegate(LogLevel log_level, string message);

		private static LogUtil _instance;

		private static object InitializeLoggingLock;

		private bool _disposed;

		static LogUtil()
		{
		}

		public static void InitializeLogging()
		{
		}

		internal static Firebase.Platform.PlatformLogLevel ConvertLogLevel(LogLevel logLevel)
		{
			return default(Firebase.Platform.PlatformLogLevel);
		}

		internal static void LogMessage(LogLevel logLevel, string message)
		{
		}

		internal static void LogMessageFromCallback(LogLevel logLevel, string message)
		{
		}

		~LogUtil()
		{
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}
	}
}

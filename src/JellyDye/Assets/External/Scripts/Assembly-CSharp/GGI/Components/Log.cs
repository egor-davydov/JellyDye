using System.Runtime.CompilerServices;

namespace GGI.Components
{
	public class Log : AutoSingleton<Log>
	{
		private LogLevel _level;

		private Log()
		{
			((AutoSingleton<>)(object)this)._002Ector();
		}

		public void SetLogLevel(LogLevel level, bool force = false)
		{
		}

		public LogLevel GetLogLevel()
		{
			return default(LogLevel);
		}

		public void Debug<T>(T message, [CallerMemberName] string tag = "Log")
		{
		}

		public void Info<T>(T message, [CallerMemberName] string tag = "Log")
		{
		}

		public void Error<T>(T message, [CallerMemberName] string tag = "Log")
		{
		}

		public void Exception<T>(T message, [CallerMemberName] string tag = "Log")
		{
		}

		public void Warn<T>(T message, [CallerMemberName] string tag = "Log")
		{
		}

		public void Editor<T>(T message, [CallerMemberName] string tag = "Log")
		{
		}

		private string Format<T>(string tag, string level, T message)
		{
			return null;
		}
	}
}
